using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding.Models
{
    public class WeddingsList
    {
        public List<WeddingModel> ListOfWeddings { get; set; }
    }
}