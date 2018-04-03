using System.Collections.Generic;

namespace ASPNetCoreAngularApp2.Library.Dto
{
    public abstract class LinkedResourceBaseDto
    {
        public List<LinkDto> Links { get; set; }
        = new List<LinkDto>();
    }
}
