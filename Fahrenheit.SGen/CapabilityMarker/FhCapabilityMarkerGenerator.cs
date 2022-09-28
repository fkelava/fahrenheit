using Microsoft.CodeAnalysis;

namespace Fahrenheit.SGen.CapabilityMarker;

[Generator]
public class FhCapabilityMarkerGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        IncrementalValuesProvider<AdditionalText> fhFileLists = context.AdditionalTextsProvider.Where(s => s.Path.Equals("FhXFileList.csv") ||
                                                                                                           s.Path.Equals("FhX2FileList.csv"));
    }
}