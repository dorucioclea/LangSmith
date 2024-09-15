#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Comparative Experiment<br/>
        /// Delete a specific comparative experiment.
        /// </summary>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse> DeleteComparativeExperimentAsync(
            global::System.Guid comparativeExperimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}