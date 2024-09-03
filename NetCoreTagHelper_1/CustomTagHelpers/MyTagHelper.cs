using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NetCoreTagHelper_1.CustomTagHelpers
{

    //Bir class'ın TagHelper olabilmesi icin TagHelper class'ından miras alması gereklidir


    [HtmlTargetElement("myOwn")] //BU ifade yarattıgımız element hangi isimle kullanılacak bunu belirtir
    public class MyTagHelper : TagHelper
    {

        public string Isim { get; set; }
        public string SoyIsim { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<h1> Hosgeldin {Isim} {SoyIsim} </h1>");
        }

    }



  


  
}
