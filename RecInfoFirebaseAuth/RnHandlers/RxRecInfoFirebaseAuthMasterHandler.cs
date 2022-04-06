using FluentlyHttpClient;
using RecInfoFirebaseAuth.RnConfig;
using RecInfoFirebaseAuth.RnOpration;

namespace RecInfoFirebaseAuth.RnHandlers;

public class RxRecInfoFirebaseAuthMasterHandler<TResponse, TModel> where TModel : class
{
    protected readonly RxRecInfoFirebaseAuthUrlConfig AuthUrlConfig;
    protected readonly RxRecInfoFirebaseAuthExecutor<TResponse, TModel> Executor;

    protected RxRecInfoFirebaseAuthMasterHandler(RxRecInfoFirebaseAuthUrlConfig authUrlConfig,
        IFluentHttpClientFactory fluentHttpClientFactory)
    {
        AuthUrlConfig = authUrlConfig;
        Executor = new RxRecInfoFirebaseAuthExecutor<TResponse, TModel>(fluentHttpClientFactory);
    }
}