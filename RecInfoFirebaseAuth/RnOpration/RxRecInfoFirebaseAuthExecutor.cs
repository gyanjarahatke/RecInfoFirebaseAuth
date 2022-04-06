using FluentlyHttpClient;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnOpration.RnResponse;
using RecInfoFirebaseAuth.RnOpration.RnResponse.RnErrorResponse;

namespace RecInfoFirebaseAuth.RnOpration
{
    public class RxRecInfoFirebaseAuthExecutor<TSuccess,TModel> where TModel : class
    {
        private readonly IFluentHttpClientFactory _fluentHttpClientFactory;

        public RxRecInfoFirebaseAuthExecutor(IFluentHttpClientFactory fluentHttpClientFactory)
        {
            _fluentHttpClientFactory = fluentHttpClientFactory;
        }


        private IFluentHttpClient GetHttpClient()
        {
            return _fluentHttpClientFactory.Get(identifier: RxRecInfoFirebaseAuthUrlConfig.HttpPlatformName);
        }
        
    
        public async Task<RxGlobalResponse<TSuccess>> ExecutorPostBody(string path, TModel mode)
        {
            try
            {
                var r = await GetHttpClient().CreateRequest(path).AsPost() // set as HTTP Post
                    .WithBody(mode)
                    .ReturnAsResponse();
                if (r.IsSuccessStatusCode)
                { 
                    return new RxGlobalResponse<TSuccess>().SetSuccess(await r.Content.ReadAsAsync<TSuccess>());
                }
                return new RxGlobalResponse<TSuccess>().SetError(await r.Content.ReadAsAsync<RxGlobalErrorResponse>());
            }
            catch (Exception e)
            {
                return new RxGlobalResponse<TSuccess>();
            }

        }
    }
}