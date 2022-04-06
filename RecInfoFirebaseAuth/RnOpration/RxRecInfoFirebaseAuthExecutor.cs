using FluentlyHttpClient;
using RecInfoFirebaseAuth.RnOpration.RnResponse;

namespace RecInfoFirebaseAuth.RnOpration
{
    public class RxRecInfoFirebaseAuthExecutor<TModel> where TModel : class
    {
        private readonly FluentHttpClientFactory _fluentHttpClientFactory;
        private readonly FluentHttpClient _fluentHttpClient;

        public RxRecInfoFirebaseAuthExecutor(FluentHttpClientFactory fluentHttpClientFactory, FluentHttpClient fluentHttpClient)
        {
            _fluentHttpClientFactory = fluentHttpClientFactory;
            _fluentHttpClient = fluentHttpClient;
        }


        public async Task<RxGlobalResponse> ExecutorPost(string path, TModel mode)
        {
            try
            {
                var httpClient = _fluentHttpClientFactory.Get(identifier: "platform");
                return await httpClient.Post<RxGlobalResponse>(path, mode);
            }
            catch (Exception e)
            {
                Exception c = e;
                return null ;
            }
        }

        public async Task<RxGlobalResponse> ExecutorPostBody(string path, TModel mode)
        {
            return await _fluentHttpClient.CreateRequest(path).AsPost() // set as HTTP Post
                                                                        .WithBody(mode) // serialize body content
                                                                        .WithSuccessStatus() // ensure response success status
                                                                        .Return<RxGlobalResponse>();

        }
    }
}