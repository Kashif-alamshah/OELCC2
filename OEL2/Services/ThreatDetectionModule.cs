namespace OEL2.Services
{
    public class ThreatDetectionModule
    {
        private static readonly List<string> maliciousPatterns = new List<string>
        {
            "SELECT *", "DROP TABLE", "<script>", "rm -rf", "UNION SELECT"
        };

        public static bool IsMalicious(string input)
        {
            return maliciousPatterns.Any(pattern => input.ToLower().Contains(pattern.ToLower()));

        }

        public static string AnalyzeScript(string input)
        {
            return IsMalicious(input) ? "⚠️ Potential Threat Detected!" : "✅ Script is Safe.";
        }
    }
}
