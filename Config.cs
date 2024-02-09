using Newtonsoft.Json.Linq;

namespace Monitor.Globals {
    public static class Config {
        public static string Version = "1.0.0";

        public static int ApplicationPort {
            get {
                using StreamReader reader = new StreamReader("config.json");
                try {
                    var json = reader.ReadToEnd();
                    JObject config = JObject.Parse(json);
                    var obj = int.Parse(config!["general"]!["application_port"]!.ToString() ?? "8080");
                    return obj;
                } catch (Exception e) {
                    Console.WriteLine(e);
                    return 8080;
                }
            }
        }
    }
}