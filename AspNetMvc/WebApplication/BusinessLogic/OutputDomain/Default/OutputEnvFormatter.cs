using System;

namespace BusinessLogic.OutputDomain.Default
{
    internal sealed class OutputEnvFormatter : IOutputEnvFormatter {

        private readonly IDateProvider _dateProvider;

        public OutputEnvFormatter( IDateProvider dateProvider ) {
            _dateProvider = dateProvider;
        }


        public string FormatLine( string line ) {
            return $"{_dateProvider.GetDateTime()} > {line}";
        }

    }
}
