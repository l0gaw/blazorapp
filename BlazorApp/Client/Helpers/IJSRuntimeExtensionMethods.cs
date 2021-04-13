using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorApp.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {     
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);        
        }
    }
}
