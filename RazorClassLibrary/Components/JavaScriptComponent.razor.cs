using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Components
{
    public partial class JavaScriptComponent : IAsyncDisposable
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        
        private string message;
        private IJSObjectReference jsModule;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/RazorClassLibrary/Components/JavaScriptComponent.razor.js");
            }
        }

        public async void ShowPrompt()
        {
            if (jsModule != null)
            {
                var result = await jsModule.InvokeAsync<string>("showPrompt", "Awesome Title from Blazor");
                if (!string.IsNullOrWhiteSpace(result))
                {
                    message = result;
                    StateHasChanged();
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (jsModule != null)
            {
                await jsModule.DisposeAsync();
            }
        }
    }
}
