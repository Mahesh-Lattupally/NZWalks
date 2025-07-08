using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly NZWalksDbContext nZWalksDbContext;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, NZWalksDbContext nZWalksDbContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            HttpContextAccessor = httpContextAccessor;
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public IHttpContextAccessor HttpContextAccessor { get; }

        async Task<Image> IImageRepository.Upload(Image image)
        {
            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{image.FileName}{image.FileExtension}");

            // Upload Image to Local Path
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            // https://localhost:portnumber/images/image.jpg
            var urlFilePath = $"{HttpContextAccessor.HttpContext.Request.Scheme}://{HttpContextAccessor.HttpContext.Request.Host}{HttpContextAccessor.HttpContext.Request.PathBase}/Images/{image.FileName}{image.FileExtension}";
            
            image.FilePath = urlFilePath;

            //Add the Image to the Images Table
            await nZWalksDbContext.Images.AddAsync(image);
            await nZWalksDbContext.SaveChangesAsync();

            return image;
        }
    }
}
