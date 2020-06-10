using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Book
    {
        private int id;
        private string name;
        private string tacgia;
        private string img_cover;


        public Book()
        {

        }

        public Book(int id,string name,string tacgia,string img_cover)
        {
            this.id = id;
            this.name = name;
            this.tacgia = tacgia;
            this.img_cover = img_cover;
        }
        
        public int Id
        {
            get { return id; }
            set {id=value; }
            
        }
        
        [Required(ErrorMessage="Name khong dc de trong !")]
        [StringLength(250,ErrorMessage ="Name Khong qua 250 ky tu")]
        [Display(Name="Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tacgia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
        public string Img_cover
        {
            get { return img_cover; }
            set { img_cover = value; }
        }
     

    }

}