using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace FluxorDemo01.Pages
{
    public class ActionHandler
    {
        [ReducerMethod]
        public static FetchingState Reduce(
            FetchingState state,
            IsFetchingAction action)
        {
            return new FetchingState(isFetching: true);
        }

        [ReducerMethod]
        public static FetchingState Reduce(
            FetchingState state,
            HasFetchedAction action)
        {
            return new FetchingState(isFetching: false);
        }
    }
}
