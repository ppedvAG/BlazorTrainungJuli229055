using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainungJuli229055.Pages.Modul5
{
    public class BootstrapCSSFixFieldClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
          var isinvalid=  editContext.GetValidationMessages(fieldIdentifier).Any();

            return isinvalid ? "is-invalid" : "is-valid";

        }
    }
}
