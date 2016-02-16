using System.ComponentModel.DataAnnotations;
using MVCMusicStore_08.Infrastructrue;

namespace MVCMusicStore_08.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(60)]
        [MaxWords(10)]
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}