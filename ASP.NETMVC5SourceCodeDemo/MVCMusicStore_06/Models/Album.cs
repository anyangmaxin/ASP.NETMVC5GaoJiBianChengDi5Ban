using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MVCMusicStore_06.Infrastructure;

namespace MVCMusicStore_06.Models
{
    public class Album
    {
       public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        [Required]
        [MaxWords(10,ErrorMessage = "There are too many words in {0}")]
        [Remote("CheckTitle","Home")]
        public virtual string Title { get; set; }
        [Range(typeof(decimal),"0.00","49.99")]
        public virtual decimal Price { get; set; }
        public virtual  string AlbumAtrUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}