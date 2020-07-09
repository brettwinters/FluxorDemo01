using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fluxor;

namespace FluxorDemo01.Pages
{
    public class FetchingStateFeature : Feature<FetchingState>
    {
        public override string GetName() => nameof(FetchingState);

        protected override FetchingState GetInitialState() => new FetchingState(isFetching: false);
    }
}
