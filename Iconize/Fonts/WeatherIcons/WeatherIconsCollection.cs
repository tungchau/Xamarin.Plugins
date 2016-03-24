using System.Collections.Generic;

namespace Plugin.Iconize.Fonts
{
    /// <summary>
    /// Defines the <see cref="WeatherIconsCollection" /> icon collection.
    /// </summary>
    public static class WeatherIconsCollection
    {
        /// <summary>
        /// Gets the icons.
        /// </summary>
        /// <value>
        /// The icons.
        /// </value>
        public static IList<IIcon> Icons { get; } = new List<IIcon>();

        /// <summary>
        /// Initializes the <see cref="WeatherIconsCollection" /> class.
        /// </summary>
        static WeatherIconsCollection()
        {
            Icons.Add("wi-day-sunny", '\uf00d');
            Icons.Add("wi-day-cloudy", '\uf002');
            Icons.Add("wi-day-cloudy-gusts", '\uf000');
            Icons.Add("wi-day-cloudy-windy", '\uf001');
            Icons.Add("wi-day-fog", '\uf003');
            Icons.Add("wi-day-hail", '\uf004');
            Icons.Add("wi-day-haze", '\uf0b6');
            Icons.Add("wi-day-lightning", '\uf005');
            Icons.Add("wi-day-rain", '\uf008');
            Icons.Add("wi-day-rain-mix", '\uf006');
            Icons.Add("wi-day-rain-wind", '\uf007');
            Icons.Add("wi-day-showers", '\uf009');
            Icons.Add("wi-day-sleet", '\uf0b2');
            Icons.Add("wi-day-sleet-storm", '\uf068');
            Icons.Add("wi-day-snow", '\uf00a');
            Icons.Add("wi-day-snow-thunderstorm", '\uf06b');
            Icons.Add("wi-day-snow-wind", '\uf065');
            Icons.Add("wi-day-sprinkle", '\uf00b');
            Icons.Add("wi-day-storm-showers", '\uf00e');
            Icons.Add("wi-day-sunny-overcast", '\uf00c');
            Icons.Add("wi-day-thunderstorm", '\uf010');
            Icons.Add("wi-day-windy", '\uf085');
            Icons.Add("wi-solar-eclipse", '\uf06e');
            Icons.Add("wi-hot", '\uf072');
            Icons.Add("wi-day-cloudy-high", '\uf07d');
            Icons.Add("wi-day-light-wind", '\uf0c4');
            Icons.Add("wi-night-clear", '\uf02e');
            Icons.Add("wi-night-alt-cloudy", '\uf086');
            Icons.Add("wi-night-alt-cloudy-gusts", '\uf022');
            Icons.Add("wi-night-alt-cloudy-windy", '\uf023');
            Icons.Add("wi-night-alt-hail", '\uf024');
            Icons.Add("wi-night-alt-lightning", '\uf025');
            Icons.Add("wi-night-alt-rain", '\uf028');
            Icons.Add("wi-night-alt-rain-mix", '\uf026');
            Icons.Add("wi-night-alt-rain-wind", '\uf027');
            Icons.Add("wi-night-alt-showers", '\uf029');
            Icons.Add("wi-night-alt-sleet", '\uf0b4');
            Icons.Add("wi-night-alt-sleet-storm", '\uf06a');
            Icons.Add("wi-night-alt-snow", '\uf02a');
            Icons.Add("wi-night-alt-snow-thunderstorm", '\uf06d');
            Icons.Add("wi-night-alt-snow-wind", '\uf067');
            Icons.Add("wi-night-alt-sprinkle", '\uf02b');
            Icons.Add("wi-night-alt-storm-showers", '\uf02c');
            Icons.Add("wi-night-alt-thunderstorm", '\uf02d');
            Icons.Add("wi-night-cloudy", '\uf031');
            Icons.Add("wi-night-cloudy-gusts", '\uf02f');
            Icons.Add("wi-night-cloudy-windy", '\uf030');
            Icons.Add("wi-night-fog", '\uf04a');
            Icons.Add("wi-night-hail", '\uf032');
            Icons.Add("wi-night-lightning", '\uf033');
            Icons.Add("wi-night-partly-cloudy", '\uf083');
            Icons.Add("wi-night-rain", '\uf036');
            Icons.Add("wi-night-rain-mix", '\uf034');
            Icons.Add("wi-night-rain-wind", '\uf035');
            Icons.Add("wi-night-showers", '\uf037');
            Icons.Add("wi-night-sleet", '\uf0b3');
            Icons.Add("wi-night-sleet-storm", '\uf069');
            Icons.Add("wi-night-snow", '\uf038');
            Icons.Add("wi-night-snow-thunderstorm", '\uf06c');
            Icons.Add("wi-night-snow-wind", '\uf066');
            Icons.Add("wi-night-sprinkle", '\uf039');
            Icons.Add("wi-night-storm-showers", '\uf03a');
            Icons.Add("wi-night-thunderstorm", '\uf03b');
            Icons.Add("wi-lunar-eclipse", '\uf070');
            Icons.Add("wi-stars", '\uf077');
            Icons.Add("wi-night-alt-cloudy-high", '\uf07e');
            Icons.Add("wi-night-cloudy-high", '\uf080');
            Icons.Add("wi-night-alt-partly-cloudy", '\uf081');
            Icons.Add("wi-cloud", '\uf041');
            Icons.Add("wi-cloudy", '\uf013');
            Icons.Add("wi-cloudy-gusts", '\uf011');
            Icons.Add("wi-cloudy-windy", '\uf012');
            Icons.Add("wi-fog", '\uf014');
            Icons.Add("wi-hail", '\uf015');
            Icons.Add("wi-rain", '\uf019');
            Icons.Add("wi-rain-mix", '\uf017');
            Icons.Add("wi-rain-wind", '\uf018');
            Icons.Add("wi-showers", '\uf01a');
            Icons.Add("wi-sleet", '\uf0b5');
            Icons.Add("wi-snow", '\uf01b');
            Icons.Add("wi-sprinkle", '\uf01c');
            Icons.Add("wi-storm-showers", '\uf01d');
            Icons.Add("wi-thunderstorm", '\uf01e');
            Icons.Add("wi-snow-wind", '\uf064');
            Icons.Add("wi-smog", '\uf074');
            Icons.Add("wi-smoke", '\uf062');
            Icons.Add("wi-lightning", '\uf016');
            Icons.Add("wi-raindrops", '\uf04e');
            Icons.Add("wi-raindrop", '\uf078');
            Icons.Add("wi-dust", '\uf063');
            Icons.Add("wi-snowflake-cold", '\uf076');
            Icons.Add("wi-windy", '\uf021');
            Icons.Add("wi-strong-wind", '\uf050');
            Icons.Add("wi-sandstorm", '\uf082');
            Icons.Add("wi-earthquake", '\uf0c6');
            Icons.Add("wi-fire", '\uf0c7');
            Icons.Add("wi-flood", '\uf07c');
            Icons.Add("wi-meteor", '\uf071');
            Icons.Add("wi-tsunami", '\uf0c5');
            Icons.Add("wi-volcano", '\uf0c8');
            Icons.Add("wi-hurricane", '\uf073');
            Icons.Add("wi-tornado", '\uf056');
            Icons.Add("wi-small-craft-advisory", '\uf0cc');
            Icons.Add("wi-gale-warning", '\uf0cd');
            Icons.Add("wi-storm-warning", '\uf0ce');
            Icons.Add("wi-hurricane-warning", '\uf0cf');
            Icons.Add("wi-wind-direction", '\uf0b1');
            Icons.Add("wi-alien", '\uf075');
            Icons.Add("wi-celsius", '\uf03c');
            Icons.Add("wi-fahrenheit", '\uf045');
            Icons.Add("wi-degrees", '\uf042');
            Icons.Add("wi-thermometer", '\uf055');
            Icons.Add("wi-thermometer-exterior", '\uf053');
            Icons.Add("wi-thermometer-internal", '\uf054');
            Icons.Add("wi-cloud-down", '\uf03d');
            Icons.Add("wi-cloud-up", '\uf040');
            Icons.Add("wi-cloud-refresh", '\uf03e');
            Icons.Add("wi-horizon", '\uf047');
            Icons.Add("wi-horizon-alt", '\uf046');
            Icons.Add("wi-sunrise", '\uf051');
            Icons.Add("wi-sunset", '\uf052');
            Icons.Add("wi-moonrise", '\uf0c9');
            Icons.Add("wi-moonset", '\uf0ca');
            Icons.Add("wi-refresh", '\uf04c');
            Icons.Add("wi-refresh-alt", '\uf04b');
            Icons.Add("wi-umbrella", '\uf084');
            Icons.Add("wi-barometer", '\uf079');
            Icons.Add("wi-humidity", '\uf07a');
            Icons.Add("wi-na", '\uf07b');
            Icons.Add("wi-train", '\uf0cb');
            Icons.Add("wi-moon-new", '\uf095');
            Icons.Add("wi-moon-waxing-crescent-1", '\uf096');
            Icons.Add("wi-moon-waxing-crescent-2", '\uf097');
            Icons.Add("wi-moon-waxing-crescent-3", '\uf098');
            Icons.Add("wi-moon-waxing-crescent-4", '\uf099');
            Icons.Add("wi-moon-waxing-crescent-5", '\uf09a');
            Icons.Add("wi-moon-waxing-crescent-6", '\uf09b');
            Icons.Add("wi-moon-first-quarter", '\uf09c');
            Icons.Add("wi-moon-waxing-gibbous-1", '\uf09d');
            Icons.Add("wi-moon-waxing-gibbous-2", '\uf09e');
            Icons.Add("wi-moon-waxing-gibbous-3", '\uf09f');
            Icons.Add("wi-moon-waxing-gibbous-4", '\uf0a0');
            Icons.Add("wi-moon-waxing-gibbous-5", '\uf0a1');
            Icons.Add("wi-moon-waxing-gibbous-6", '\uf0a2');
            Icons.Add("wi-moon-full", '\uf0a3');
            Icons.Add("wi-moon-waning-gibbous-1", '\uf0a4');
            Icons.Add("wi-moon-waning-gibbous-2", '\uf0a5');
            Icons.Add("wi-moon-waning-gibbous-3", '\uf0a6');
            Icons.Add("wi-moon-waning-gibbous-4", '\uf0a7');
            Icons.Add("wi-moon-waning-gibbous-5", '\uf0a8');
            Icons.Add("wi-moon-waning-gibbous-6", '\uf0a9');
            Icons.Add("wi-moon-third-quarter", '\uf0aa');
            Icons.Add("wi-moon-waning-crescent-1", '\uf0ab');
            Icons.Add("wi-moon-waning-crescent-2", '\uf0ac');
            Icons.Add("wi-moon-waning-crescent-3", '\uf0ad');
            Icons.Add("wi-moon-waning-crescent-4", '\uf0ae');
            Icons.Add("wi-moon-waning-crescent-5", '\uf0af');
            Icons.Add("wi-moon-waning-crescent-6", '\uf0b0');
            Icons.Add("wi-moon-alt-new", '\uf0eb');
            Icons.Add("wi-moon-alt-waxing-crescent-1", '\uf0d0');
            Icons.Add("wi-moon-alt-waxing-crescent-2", '\uf0d1');
            Icons.Add("wi-moon-alt-waxing-crescent-3", '\uf0d2');
            Icons.Add("wi-moon-alt-waxing-crescent-4", '\uf0d3');
            Icons.Add("wi-moon-alt-waxing-crescent-5", '\uf0d4');
            Icons.Add("wi-moon-alt-waxing-crescent-6", '\uf0d5');
            Icons.Add("wi-moon-alt-first-quarter", '\uf0d6');
            Icons.Add("wi-moon-alt-waxing-gibbous-1", '\uf0d7');
            Icons.Add("wi-moon-alt-waxing-gibbous-2", '\uf0d8');
            Icons.Add("wi-moon-alt-waxing-gibbous-3", '\uf0d9');
            Icons.Add("wi-moon-alt-waxing-gibbous-4", '\uf0da');
            Icons.Add("wi-moon-alt-waxing-gibbous-5", '\uf0db');
            Icons.Add("wi-moon-alt-waxing-gibbous-6", '\uf0dc');
            Icons.Add("wi-moon-alt-full", '\uf0dd');
            Icons.Add("wi-moon-alt-waning-gibbous-1", '\uf0de');
            Icons.Add("wi-moon-alt-waning-gibbous-2", '\uf0df');
            Icons.Add("wi-moon-alt-waning-gibbous-3", '\uf0e0');
            Icons.Add("wi-moon-alt-waning-gibbous-4", '\uf0e1');
            Icons.Add("wi-moon-alt-waning-gibbous-5", '\uf0e2');
            Icons.Add("wi-moon-alt-waning-gibbous-6", '\uf0e3');
            Icons.Add("wi-moon-alt-third-quarter", '\uf0e4');
            Icons.Add("wi-moon-alt-waning-crescent-1", '\uf0e5');
            Icons.Add("wi-moon-alt-waning-crescent-2", '\uf0e6');
            Icons.Add("wi-moon-alt-waning-crescent-3", '\uf0e7');
            Icons.Add("wi-moon-alt-waning-crescent-4", '\uf0e8');
            Icons.Add("wi-moon-alt-waning-crescent-5", '\uf0e9');
            Icons.Add("wi-moon-alt-waning-crescent-6", '\uf0ea');
            Icons.Add("wi-moon-0", '\uf095');
            Icons.Add("wi-moon-1", '\uf096');
            Icons.Add("wi-moon-2", '\uf097');
            Icons.Add("wi-moon-3", '\uf098');
            Icons.Add("wi-moon-4", '\uf099');
            Icons.Add("wi-moon-5", '\uf09a');
            Icons.Add("wi-moon-6", '\uf09b');
            Icons.Add("wi-moon-7", '\uf09c');
            Icons.Add("wi-moon-8", '\uf09d');
            Icons.Add("wi-moon-9", '\uf09e');
            Icons.Add("wi-moon-10", '\uf09f');
            Icons.Add("wi-moon-11", '\uf0a0');
            Icons.Add("wi-moon-12", '\uf0a1');
            Icons.Add("wi-moon-13", '\uf0a2');
            Icons.Add("wi-moon-14", '\uf0a3');
            Icons.Add("wi-moon-15", '\uf0a4');
            Icons.Add("wi-moon-16", '\uf0a5');
            Icons.Add("wi-moon-17", '\uf0a6');
            Icons.Add("wi-moon-18", '\uf0a7');
            Icons.Add("wi-moon-19", '\uf0a8');
            Icons.Add("wi-moon-20", '\uf0a9');
            Icons.Add("wi-moon-21", '\uf0aa');
            Icons.Add("wi-moon-22", '\uf0ab');
            Icons.Add("wi-moon-23", '\uf0ac');
            Icons.Add("wi-moon-24", '\uf0ad');
            Icons.Add("wi-moon-25", '\uf0ae');
            Icons.Add("wi-moon-26", '\uf0af');
            Icons.Add("wi-moon-27", '\uf0b0');
            Icons.Add("wi-time-1", '\uf08a');
            Icons.Add("wi-time-2", '\uf08b');
            Icons.Add("wi-time-3", '\uf08c');
            Icons.Add("wi-time-4", '\uf08d');
            Icons.Add("wi-time-5", '\uf08e');
            Icons.Add("wi-time-6", '\uf08f');
            Icons.Add("wi-time-7", '\uf090');
            Icons.Add("wi-time-8", '\uf091');
            Icons.Add("wi-time-9", '\uf092');
            Icons.Add("wi-time-10", '\uf093');
            Icons.Add("wi-time-11", '\uf094');
            Icons.Add("wi-time-12", '\uf089');
            Icons.Add("wi-direction-up", '\uf058');
            Icons.Add("wi-direction-up-right", '\uf057');
            Icons.Add("wi-direction-right", '\uf04d');
            Icons.Add("wi-direction-down-right", '\uf088');
            Icons.Add("wi-direction-down", '\uf044');
            Icons.Add("wi-direction-down-left", '\uf043');
            Icons.Add("wi-direction-left", '\uf048');
            Icons.Add("wi-direction-up-left", '\uf087');
            Icons.Add("wi-wind-beaufort-0", '\uf0b7');
            Icons.Add("wi-wind-beaufort-1", '\uf0b8');
            Icons.Add("wi-wind-beaufort-2", '\uf0b9');
            Icons.Add("wi-wind-beaufort-3", '\uf0ba');
            Icons.Add("wi-wind-beaufort-4", '\uf0bb');
            Icons.Add("wi-wind-beaufort-5", '\uf0bc');
            Icons.Add("wi-wind-beaufort-6", '\uf0bd');
            Icons.Add("wi-wind-beaufort-7", '\uf0be');
            Icons.Add("wi-wind-beaufort-8", '\uf0bf');
            Icons.Add("wi-wind-beaufort-9", '\uf0c0');
            Icons.Add("wi-wind-beaufort-10", '\uf0c1');
            Icons.Add("wi-wind-beaufort-11", '\uf0c2');
            Icons.Add("wi-wind-beaufort-12", '\uf0c3');
            Icons.Add("wi-yahoo-0", '\uf056');
            Icons.Add("wi-yahoo-1", '\uf00e');
            Icons.Add("wi-yahoo-2", '\uf073');
            Icons.Add("wi-yahoo-3", '\uf01e');
            Icons.Add("wi-yahoo-4", '\uf01e');
            Icons.Add("wi-yahoo-5", '\uf017');
            Icons.Add("wi-yahoo-6", '\uf017');
            Icons.Add("wi-yahoo-7", '\uf017');
            Icons.Add("wi-yahoo-8", '\uf015');
            Icons.Add("wi-yahoo-9", '\uf01a');
            Icons.Add("wi-yahoo-10", '\uf015');
            Icons.Add("wi-yahoo-11", '\uf01a');
            Icons.Add("wi-yahoo-12", '\uf01a');
            Icons.Add("wi-yahoo-13", '\uf01b');
            Icons.Add("wi-yahoo-14", '\uf00a');
            Icons.Add("wi-yahoo-15", '\uf064');
            Icons.Add("wi-yahoo-16", '\uf01b');
            Icons.Add("wi-yahoo-17", '\uf015');
            Icons.Add("wi-yahoo-18", '\uf017');
            Icons.Add("wi-yahoo-19", '\uf063');
            Icons.Add("wi-yahoo-20", '\uf014');
            Icons.Add("wi-yahoo-21", '\uf021');
            Icons.Add("wi-yahoo-22", '\uf062');
            Icons.Add("wi-yahoo-23", '\uf050');
            Icons.Add("wi-yahoo-24", '\uf050');
            Icons.Add("wi-yahoo-25", '\uf076');
            Icons.Add("wi-yahoo-26", '\uf013');
            Icons.Add("wi-yahoo-27", '\uf031');
            Icons.Add("wi-yahoo-28", '\uf002');
            Icons.Add("wi-yahoo-29", '\uf031');
            Icons.Add("wi-yahoo-30", '\uf002');
            Icons.Add("wi-yahoo-31", '\uf02e');
            Icons.Add("wi-yahoo-32", '\uf00d');
            Icons.Add("wi-yahoo-33", '\uf083');
            Icons.Add("wi-yahoo-34", '\uf00c');
            Icons.Add("wi-yahoo-35", '\uf017');
            Icons.Add("wi-yahoo-36", '\uf072');
            Icons.Add("wi-yahoo-37", '\uf00e');
            Icons.Add("wi-yahoo-38", '\uf00e');
            Icons.Add("wi-yahoo-39", '\uf00e');
            Icons.Add("wi-yahoo-40", '\uf01a');
            Icons.Add("wi-yahoo-41", '\uf064');
            Icons.Add("wi-yahoo-42", '\uf01b');
            Icons.Add("wi-yahoo-43", '\uf064');
            Icons.Add("wi-yahoo-44", '\uf00c');
            Icons.Add("wi-yahoo-45", '\uf00e');
            Icons.Add("wi-yahoo-46", '\uf01b');
            Icons.Add("wi-yahoo-47", '\uf00e');
            Icons.Add("wi-yahoo-3200", '\uf077');
            Icons.Add("wi-forecast-io-clear-day", '\uf00d');
            Icons.Add("wi-forecast-io-clear-night", '\uf02e');
            Icons.Add("wi-forecast-io-rain", '\uf019');
            Icons.Add("wi-forecast-io-snow", '\uf01b');
            Icons.Add("wi-forecast-io-sleet", '\uf0b5');
            Icons.Add("wi-forecast-io-wind", '\uf050');
            Icons.Add("wi-forecast-io-fog", '\uf014');
            Icons.Add("wi-forecast-io-cloudy", '\uf013');
            Icons.Add("wi-forecast-io-partly-cloudy-day", '\uf002');
            Icons.Add("wi-forecast-io-partly-cloudy-night", '\uf031');
            Icons.Add("wi-forecast-io-hail", '\uf015');
            Icons.Add("wi-forecast-io-thunderstorm", '\uf01e');
            Icons.Add("wi-forecast-io-tornado", '\uf056');
            Icons.Add("wi-wmo4680-0", '\uf055');
            Icons.Add("wi-wmo4680-00", '\uf055');
            Icons.Add("wi-wmo4680-1", '\uf013');
            Icons.Add("wi-wmo4680-01", '\uf013');
            Icons.Add("wi-wmo4680-2", '\uf055');
            Icons.Add("wi-wmo4680-02", '\uf055');
            Icons.Add("wi-wmo4680-3", '\uf013');
            Icons.Add("wi-wmo4680-03", '\uf013');
            Icons.Add("wi-wmo4680-4", '\uf014');
            Icons.Add("wi-wmo4680-04", '\uf014');
            Icons.Add("wi-wmo4680-5", '\uf014');
            Icons.Add("wi-wmo4680-05", '\uf014');
            Icons.Add("wi-wmo4680-10", '\uf014');
            Icons.Add("wi-wmo4680-11", '\uf014');
            Icons.Add("wi-wmo4680-12", '\uf016');
            Icons.Add("wi-wmo4680-18", '\uf050');
            Icons.Add("wi-wmo4680-20", '\uf014');
            Icons.Add("wi-wmo4680-21", '\uf017');
            Icons.Add("wi-wmo4680-22", '\uf017');
            Icons.Add("wi-wmo4680-23", '\uf019');
            Icons.Add("wi-wmo4680-24", '\uf01b');
            Icons.Add("wi-wmo4680-25", '\uf015');
            Icons.Add("wi-wmo4680-26", '\uf01e');
            Icons.Add("wi-wmo4680-27", '\uf063');
            Icons.Add("wi-wmo4680-28", '\uf063');
            Icons.Add("wi-wmo4680-29", '\uf063');
            Icons.Add("wi-wmo4680-30", '\uf014');
            Icons.Add("wi-wmo4680-31", '\uf014');
            Icons.Add("wi-wmo4680-32", '\uf014');
            Icons.Add("wi-wmo4680-33", '\uf014');
            Icons.Add("wi-wmo4680-34", '\uf014');
            Icons.Add("wi-wmo4680-35", '\uf014');
            Icons.Add("wi-wmo4680-40", '\uf017');
            Icons.Add("wi-wmo4680-41", '\uf01c');
            Icons.Add("wi-wmo4680-42", '\uf019');
            Icons.Add("wi-wmo4680-43", '\uf01c');
            Icons.Add("wi-wmo4680-44", '\uf019');
            Icons.Add("wi-wmo4680-45", '\uf015');
            Icons.Add("wi-wmo4680-46", '\uf015');
            Icons.Add("wi-wmo4680-47", '\uf01b');
            Icons.Add("wi-wmo4680-48", '\uf01b');
            Icons.Add("wi-wmo4680-50", '\uf01c');
            Icons.Add("wi-wmo4680-51", '\uf01c');
            Icons.Add("wi-wmo4680-52", '\uf019');
            Icons.Add("wi-wmo4680-53", '\uf019');
            Icons.Add("wi-wmo4680-54", '\uf076');
            Icons.Add("wi-wmo4680-55", '\uf076');
            Icons.Add("wi-wmo4680-56", '\uf076');
            Icons.Add("wi-wmo4680-57", '\uf01c');
            Icons.Add("wi-wmo4680-58", '\uf019');
            Icons.Add("wi-wmo4680-60", '\uf01c');
            Icons.Add("wi-wmo4680-61", '\uf01c');
            Icons.Add("wi-wmo4680-62", '\uf019');
            Icons.Add("wi-wmo4680-63", '\uf019');
            Icons.Add("wi-wmo4680-64", '\uf015');
            Icons.Add("wi-wmo4680-65", '\uf015');
            Icons.Add("wi-wmo4680-66", '\uf015');
            Icons.Add("wi-wmo4680-67", '\uf017');
            Icons.Add("wi-wmo4680-68", '\uf017');
            Icons.Add("wi-wmo4680-70", '\uf01b');
            Icons.Add("wi-wmo4680-71", '\uf01b');
            Icons.Add("wi-wmo4680-72", '\uf01b');
            Icons.Add("wi-wmo4680-73", '\uf01b');
            Icons.Add("wi-wmo4680-74", '\uf076');
            Icons.Add("wi-wmo4680-75", '\uf076');
            Icons.Add("wi-wmo4680-76", '\uf076');
            Icons.Add("wi-wmo4680-77", '\uf01b');
            Icons.Add("wi-wmo4680-78", '\uf076');
            Icons.Add("wi-wmo4680-80", '\uf019');
            Icons.Add("wi-wmo4680-81", '\uf01c');
            Icons.Add("wi-wmo4680-82", '\uf019');
            Icons.Add("wi-wmo4680-83", '\uf019');
            Icons.Add("wi-wmo4680-84", '\uf01d');
            Icons.Add("wi-wmo4680-85", '\uf017');
            Icons.Add("wi-wmo4680-86", '\uf017');
            Icons.Add("wi-wmo4680-87", '\uf017');
            Icons.Add("wi-wmo4680-89", '\uf015');
            Icons.Add("wi-wmo4680-90", '\uf016');
            Icons.Add("wi-wmo4680-91", '\uf01d');
            Icons.Add("wi-wmo4680-92", '\uf01e');
            Icons.Add("wi-wmo4680-93", '\uf01e');
            Icons.Add("wi-wmo4680-94", '\uf016');
            Icons.Add("wi-wmo4680-95", '\uf01e');
            Icons.Add("wi-wmo4680-96", '\uf01e');
            Icons.Add("wi-wmo4680-99", '\uf056');
            Icons.Add("wi-owm-200", '\uf01e');
            Icons.Add("wi-owm-201", '\uf01e');
            Icons.Add("wi-owm-202", '\uf01e');
            Icons.Add("wi-owm-210", '\uf016');
            Icons.Add("wi-owm-211", '\uf016');
            Icons.Add("wi-owm-212", '\uf016');
            Icons.Add("wi-owm-221", '\uf016');
            Icons.Add("wi-owm-230", '\uf01e');
            Icons.Add("wi-owm-231", '\uf01e');
            Icons.Add("wi-owm-232", '\uf01e');
            Icons.Add("wi-owm-300", '\uf01c');
            Icons.Add("wi-owm-301", '\uf01c');
            Icons.Add("wi-owm-302", '\uf019');
            Icons.Add("wi-owm-310", '\uf017');
            Icons.Add("wi-owm-311", '\uf019');
            Icons.Add("wi-owm-312", '\uf019');
            Icons.Add("wi-owm-313", '\uf01a');
            Icons.Add("wi-owm-314", '\uf019');
            Icons.Add("wi-owm-321", '\uf01c');
            Icons.Add("wi-owm-500", '\uf01c');
            Icons.Add("wi-owm-501", '\uf019');
            Icons.Add("wi-owm-502", '\uf019');
            Icons.Add("wi-owm-503", '\uf019');
            Icons.Add("wi-owm-504", '\uf019');
            Icons.Add("wi-owm-511", '\uf017');
            Icons.Add("wi-owm-520", '\uf01a');
            Icons.Add("wi-owm-521", '\uf01a');
            Icons.Add("wi-owm-522", '\uf01a');
            Icons.Add("wi-owm-531", '\uf01d');
            Icons.Add("wi-owm-600", '\uf01b');
            Icons.Add("wi-owm-601", '\uf01b');
            Icons.Add("wi-owm-602", '\uf0b5');
            Icons.Add("wi-owm-611", '\uf017');
            Icons.Add("wi-owm-612", '\uf017');
            Icons.Add("wi-owm-615", '\uf017');
            Icons.Add("wi-owm-616", '\uf017');
            Icons.Add("wi-owm-620", '\uf017');
            Icons.Add("wi-owm-621", '\uf01b');
            Icons.Add("wi-owm-622", '\uf01b');
            Icons.Add("wi-owm-701", '\uf01a');
            Icons.Add("wi-owm-711", '\uf062');
            Icons.Add("wi-owm-721", '\uf0b6');
            Icons.Add("wi-owm-731", '\uf063');
            Icons.Add("wi-owm-741", '\uf014');
            Icons.Add("wi-owm-761", '\uf063');
            Icons.Add("wi-owm-762", '\uf063');
            Icons.Add("wi-owm-771", '\uf011');
            Icons.Add("wi-owm-781", '\uf056');
            Icons.Add("wi-owm-800", '\uf00d');
            Icons.Add("wi-owm-801", '\uf011');
            Icons.Add("wi-owm-802", '\uf011');
            Icons.Add("wi-owm-803", '\uf012');
            Icons.Add("wi-owm-804", '\uf013');
            Icons.Add("wi-owm-900", '\uf056');
            Icons.Add("wi-owm-901", '\uf01d');
            Icons.Add("wi-owm-902", '\uf073');
            Icons.Add("wi-owm-903", '\uf076');
            Icons.Add("wi-owm-904", '\uf072');
            Icons.Add("wi-owm-905", '\uf021');
            Icons.Add("wi-owm-906", '\uf015');
            Icons.Add("wi-owm-957", '\uf050');
            Icons.Add("wi-owm-day-200", '\uf010');
            Icons.Add("wi-owm-day-201", '\uf010');
            Icons.Add("wi-owm-day-202", '\uf010');
            Icons.Add("wi-owm-day-210", '\uf005');
            Icons.Add("wi-owm-day-211", '\uf005');
            Icons.Add("wi-owm-day-212", '\uf005');
            Icons.Add("wi-owm-day-221", '\uf005');
            Icons.Add("wi-owm-day-230", '\uf010');
            Icons.Add("wi-owm-day-231", '\uf010');
            Icons.Add("wi-owm-day-232", '\uf010');
            Icons.Add("wi-owm-day-300", '\uf00b');
            Icons.Add("wi-owm-day-301", '\uf00b');
            Icons.Add("wi-owm-day-302", '\uf008');
            Icons.Add("wi-owm-day-310", '\uf008');
            Icons.Add("wi-owm-day-311", '\uf008');
            Icons.Add("wi-owm-day-312", '\uf008');
            Icons.Add("wi-owm-day-313", '\uf008');
            Icons.Add("wi-owm-day-314", '\uf008');
            Icons.Add("wi-owm-day-321", '\uf00b');
            Icons.Add("wi-owm-day-500", '\uf00b');
            Icons.Add("wi-owm-day-501", '\uf008');
            Icons.Add("wi-owm-day-502", '\uf008');
            Icons.Add("wi-owm-day-503", '\uf008');
            Icons.Add("wi-owm-day-504", '\uf008');
            Icons.Add("wi-owm-day-511", '\uf006');
            Icons.Add("wi-owm-day-520", '\uf009');
            Icons.Add("wi-owm-day-521", '\uf009');
            Icons.Add("wi-owm-day-522", '\uf009');
            Icons.Add("wi-owm-day-531", '\uf00e');
            Icons.Add("wi-owm-day-600", '\uf00a');
            Icons.Add("wi-owm-day-601", '\uf0b2');
            Icons.Add("wi-owm-day-602", '\uf00a');
            Icons.Add("wi-owm-day-611", '\uf006');
            Icons.Add("wi-owm-day-612", '\uf006');
            Icons.Add("wi-owm-day-615", '\uf006');
            Icons.Add("wi-owm-day-616", '\uf006');
            Icons.Add("wi-owm-day-620", '\uf006');
            Icons.Add("wi-owm-day-621", '\uf00a');
            Icons.Add("wi-owm-day-622", '\uf00a');
            Icons.Add("wi-owm-day-701", '\uf009');
            Icons.Add("wi-owm-day-711", '\uf062');
            Icons.Add("wi-owm-day-721", '\uf0b6');
            Icons.Add("wi-owm-day-731", '\uf063');
            Icons.Add("wi-owm-day-741", '\uf003');
            Icons.Add("wi-owm-day-761", '\uf063');
            Icons.Add("wi-owm-day-762", '\uf063');
            Icons.Add("wi-owm-day-781", '\uf056');
            Icons.Add("wi-owm-day-800", '\uf00d');
            Icons.Add("wi-owm-day-801", '\uf000');
            Icons.Add("wi-owm-day-802", '\uf000');
            Icons.Add("wi-owm-day-803", '\uf000');
            Icons.Add("wi-owm-day-804", '\uf00c');
            Icons.Add("wi-owm-day-900", '\uf056');
            Icons.Add("wi-owm-day-902", '\uf073');
            Icons.Add("wi-owm-day-903", '\uf076');
            Icons.Add("wi-owm-day-904", '\uf072');
            Icons.Add("wi-owm-day-906", '\uf004');
            Icons.Add("wi-owm-day-957", '\uf050');
            Icons.Add("wi-owm-night-200", '\uf02d');
            Icons.Add("wi-owm-night-201", '\uf02d');
            Icons.Add("wi-owm-night-202", '\uf02d');
            Icons.Add("wi-owm-night-210", '\uf025');
            Icons.Add("wi-owm-night-211", '\uf025');
            Icons.Add("wi-owm-night-212", '\uf025');
            Icons.Add("wi-owm-night-221", '\uf025');
            Icons.Add("wi-owm-night-230", '\uf02d');
            Icons.Add("wi-owm-night-231", '\uf02d');
            Icons.Add("wi-owm-night-232", '\uf02d');
            Icons.Add("wi-owm-night-300", '\uf02b');
            Icons.Add("wi-owm-night-301", '\uf02b');
            Icons.Add("wi-owm-night-302", '\uf028');
            Icons.Add("wi-owm-night-310", '\uf028');
            Icons.Add("wi-owm-night-311", '\uf028');
            Icons.Add("wi-owm-night-312", '\uf028');
            Icons.Add("wi-owm-night-313", '\uf028');
            Icons.Add("wi-owm-night-314", '\uf028');
            Icons.Add("wi-owm-night-321", '\uf02b');
            Icons.Add("wi-owm-night-500", '\uf02b');
            Icons.Add("wi-owm-night-501", '\uf028');
            Icons.Add("wi-owm-night-502", '\uf028');
            Icons.Add("wi-owm-night-503", '\uf028');
            Icons.Add("wi-owm-night-504", '\uf028');
            Icons.Add("wi-owm-night-511", '\uf026');
            Icons.Add("wi-owm-night-520", '\uf029');
            Icons.Add("wi-owm-night-521", '\uf029');
            Icons.Add("wi-owm-night-522", '\uf029');
            Icons.Add("wi-owm-night-531", '\uf02c');
            Icons.Add("wi-owm-night-600", '\uf02a');
            Icons.Add("wi-owm-night-601", '\uf0b4');
            Icons.Add("wi-owm-night-602", '\uf02a');
            Icons.Add("wi-owm-night-611", '\uf026');
            Icons.Add("wi-owm-night-612", '\uf026');
            Icons.Add("wi-owm-night-615", '\uf026');
            Icons.Add("wi-owm-night-616", '\uf026');
            Icons.Add("wi-owm-night-620", '\uf026');
            Icons.Add("wi-owm-night-621", '\uf02a');
            Icons.Add("wi-owm-night-622", '\uf02a');
            Icons.Add("wi-owm-night-701", '\uf029');
            Icons.Add("wi-owm-night-711", '\uf062');
            Icons.Add("wi-owm-night-721", '\uf0b6');
            Icons.Add("wi-owm-night-731", '\uf063');
            Icons.Add("wi-owm-night-741", '\uf04a');
            Icons.Add("wi-owm-night-761", '\uf063');
            Icons.Add("wi-owm-night-762", '\uf063');
            Icons.Add("wi-owm-night-781", '\uf056');
            Icons.Add("wi-owm-night-800", '\uf02e');
            Icons.Add("wi-owm-night-801", '\uf022');
            Icons.Add("wi-owm-night-802", '\uf022');
            Icons.Add("wi-owm-night-803", '\uf022');
            Icons.Add("wi-owm-night-804", '\uf086');
            Icons.Add("wi-owm-night-900", '\uf056');
            Icons.Add("wi-owm-night-902", '\uf073');
            Icons.Add("wi-owm-night-903", '\uf076');
            Icons.Add("wi-owm-night-904", '\uf072');
            Icons.Add("wi-owm-night-906", '\uf024');
            Icons.Add("wi-owm-night-957", '\uf050');
            Icons.Add("wi-wu-chanceflurries", '\uf064');
            Icons.Add("wi-wu-chancerain", '\uf019');
            Icons.Add("wi-wu-chancesleat", '\uf0b5');
            Icons.Add("wi-wu-chancesnow", '\uf01b');
            Icons.Add("wi-wu-chancetstorms", '\uf01e');
            Icons.Add("wi-wu-clear", '\uf00d');
            Icons.Add("wi-wu-cloudy", '\uf002');
            Icons.Add("wi-wu-flurries", '\uf064');
            Icons.Add("wi-wu-hazy", '\uf0b6');
            Icons.Add("wi-wu-mostlycloudy", '\uf002');
            Icons.Add("wi-wu-mostlysunny", '\uf00d');
            Icons.Add("wi-wu-partlycloudy", '\uf002');
            Icons.Add("wi-wu-partlysunny", '\uf00d');
            Icons.Add("wi-wu-rain", '\uf01a');
            Icons.Add("wi-wu-sleat", '\uf0b5');
            Icons.Add("wi-wu-snow", '\uf01b');
            Icons.Add("wi-wu-sunny", '\uf00d');
            Icons.Add("wi-wu-tstorms", '\uf01e');
            Icons.Add("wi-wu-unknown", '\uf00d');
        }
    }
}