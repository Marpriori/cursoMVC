using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Treinamento_Benner.Resources;
using Treinamento_Benner.ValidationAnnotation;

namespace Treinamento_Benner.Models
{
    [MetadataType(typeof(AlbumMetadata))]
    public class Album: IValidatableObject
    {
        public int Id { get; set; }
        public int GeneroId { get; set; }
        public int ArtistaId { get; set; }
        public string Titulo { get; set; }
        public decimal Valor { get; set; }
        public string UrlArte { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Artista Artista { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (UrlArte != null && UrlArte.EndsWith("gif"))
            {
                //yield gera o ienumerable automaticamente
                yield return new ValidationResult("Não é suportado tipo de imagem .gif", new[] { "UrlArte" });
            }
        }
    }

    public class AlbumMetadata
    {
        [Display(Name = "Gênero")]

        public int GeneroId { get; set; }

        [StringLength(160, MinimumLength = 3)]
        [Display(ResourceType = typeof(AlbumResource), Name = "Title")]
        [MaxWord(3)]
        public string Titulo { get; set; }

        
        [Display(ResourceType = typeof(AlbumResource), Name = "Price")]
        public decimal Valor { get; set; }

        [Display(ResourceType = typeof(AlbumResource), Name = "UrlArt")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"^https?://[a-zA-Z0-9çÇ./-]+[.](jpg|png|gif)$", ErrorMessage = "URL inválida.")]
        public string UrlArte { get; set; }

    }
}