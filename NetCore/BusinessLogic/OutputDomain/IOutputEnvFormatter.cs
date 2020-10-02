namespace BusinessLogic.OutputDomain
{
    /// <summary>
    /// Appends environment suffix before line
    /// </summary>
    public interface IOutputEnvFormatter
    {
        string FormatLine( string line );

    }
}
