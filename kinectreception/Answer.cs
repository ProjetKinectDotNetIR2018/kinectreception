using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinectreception
{
    public class Answer
    {
        public string code { get; set; }
        public List<Label> summary { get; set; }
        public Action action {get;set;}
    }
}
