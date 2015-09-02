﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Rabbit
{
    private static readonly List<RabbitRule> _uni2ZgRules;
    private static readonly List<RabbitRule> _zg2UniRules;

    static Rabbit()
    {
        _uni2ZgRules = new List<RabbitRule> { new RabbitRule("\u1004\u103a\u1039","\u1064"), new RabbitRule("\u1039\u1010\u103d","\u1096"), new RabbitRule("\u1014(?=[\u1030\u103d\u103e\u102f\u1039])","\u108f"), new RabbitRule("\u102b\u103a","\u105a"), new RabbitRule("\u100b\u1039\u100c","\u1092"), new RabbitRule("\u102d\u1036","\u108e"), new RabbitRule("\u104e\u1004\u103a\u1038","\u104e"), new RabbitRule("[\u1025\u1009](?=[\u1039\u102f\u1030])","\u106a"), new RabbitRule("[\u1025\u1009](?=[\u103a])","\u1025"), new RabbitRule("\u100a(?=[\u1039\u102f\u1030\u103d])","\u106b"), new RabbitRule("(\u1039[\u1000-\u1021])\u102f","$1\u1033"), new RabbitRule("(\u1039[\u1000-\u1021])\u1030","$1\u1034"), new RabbitRule("\u1039\u1000","\u1060"), new RabbitRule("\u1039\u1001","\u1061"), new RabbitRule("\u1039\u1002","\u1062"), new RabbitRule("\u1039\u1003","\u1063"), new RabbitRule("\u1039\u1005","\u1065"), new RabbitRule("\u1039\u1006","\u1066"), new RabbitRule("\u1039\u1007","\u1068"), new RabbitRule("\u1039\u1008","\u1069"), new RabbitRule("\u100a(?=[\u1039\u102f\u1030])","\u106b"), new RabbitRule("\u1039\u100b","\u106c"), new RabbitRule("\u1039\u100c","\u106d"), new RabbitRule("\u100d\u1039\u100d","\u106e"), new RabbitRule("\u100e\u1039\u100d","\u106f"), new RabbitRule("\u1039\u100f","\u1070"), new RabbitRule("\u1039\u1010","\u1071"), new RabbitRule("\u1039\u1011","\u1073"), new RabbitRule("\u1039\u1012","\u1075"), new RabbitRule("\u1039\u1013","\u1076"), new RabbitRule("\u1039\u1013","\u1076"), new RabbitRule("\u1039\u1014","\u1077"), new RabbitRule("\u1039\u1015","\u1078"), new RabbitRule("\u1039\u1016","\u1079"), new RabbitRule("\u1039\u1017","\u107a"), new RabbitRule("\u1039\u1018","\u107b"), new RabbitRule("\u1039\u1019","\u107c"), new RabbitRule("\u1039\u101c","\u1085"), new RabbitRule("\u103f","\u1086"), new RabbitRule("(\u103c)\u103e","$1\u1087"), new RabbitRule("\u103d\u103e","\u108a"), new RabbitRule("(\u1064)([\u1031]?)([\u103c]?)([\u1000-\u1021])\u102d","$2$3$4\u108b"), new RabbitRule("(\u1064)([\u1031]?)([\u103c]?)([\u1000-\u1021])\u102e","$2$3$4\u108c"), new RabbitRule("(\u1064)([\u1031]?)([\u103c]?)([\u1000-\u1021])\u1036","$2$3$4\u108d"), new RabbitRule("(\u1064)([\u1031]?)([\u103c]?)([\u1000-\u1021])","$2$3$4$1"), new RabbitRule("\u101b(?=[\u102f\u1030\u103d\u108a])","\u1090"), new RabbitRule("\u100f\u1039\u100d","\u1091"), new RabbitRule("\u100b\u1039\u100b","\u1097"), new RabbitRule("([\u1000-\u1021\u108f\u1029\u1090])([\u1060-\u1069\u106c\u106d\u1070-\u107c\u1085\u108a])?([\u103b-\u103e]*)?\u1031","\u1031$1$2$3"), new RabbitRule("([\u1000-\u1021\u1029])([\u1060-\u1069\u106c\u106d\u1070-\u107c\u1085])?(\u103c)","$3$1$2"), new RabbitRule("\u103a","\u1039"), new RabbitRule("\u103b","\u103a"), new RabbitRule("\u103c","\u103b"), new RabbitRule("\u103d","\u103c"), new RabbitRule("\u103e","\u103d"), new RabbitRule("\u103d\u102f","\u1088"), new RabbitRule("([\u102f\u1030\u1014\u101b\u103c\u108a\u103d\u1088])([\u1032\u1036]{0,1})\u1037","$1$2\u1095"), new RabbitRule("\u102f\u1095","\u102f\u1094"), new RabbitRule("([\u1014\u101b])([\u1032\u1036\u102d\u102e\u108b\u108c\u108d\u108e])\u1037","$1$2\u1095"), new RabbitRule("\u1095\u1039","\u1094\u1039"), new RabbitRule("([\u103a\u103b])([\u1000-\u1021])([\u1036\u102d\u102e\u108b\u108c\u108d\u108e]?)\u102f","$1$2$3\u1033"), new RabbitRule("([\u103a\u103b])([\u1000-\u1021])([\u1036\u102d\u102e\u108b\u108c\u108d\u108e]?)\u1030","$1$2$3\u1034"), new RabbitRule("\u103a\u102f","\u103a\u1033"), new RabbitRule("\u103a([\u1036\u102d\u102e\u108b\u108c\u108d\u108e])\u102f","\u103a$1\u1033"), new RabbitRule("([\u103a\u103b])([\u1000-\u1021])\u1030","$1$2\u1034"), new RabbitRule("\u103a\u1030","\u103a\u1034"), new RabbitRule("\u103a([\u1036\u102d\u102e\u108b\u108c\u108d\u108e])\u1030","\u103a$1\u1034"), new RabbitRule("\u103d\u1030","\u1089"), new RabbitRule("\u103b([\u1000\u1003\u1006\u100f\u1010\u1011\u1018\u101a\u101c\u101a\u101e\u101f])","\u107e$1"), new RabbitRule("\u107e([\u1000\u1003\u1006\u100f\u1010\u1011\u1018\u101a\u101c\u101a\u101e\u101f])([\u103c\u108a])([\u1032\u1036\u102d\u102e\u108b\u108c\u108d\u108e])","\u1084$1$2$3"), new RabbitRule("\u107e([\u1000\u1003\u1006\u100f\u1010\u1011\u1018\u101a\u101c\u101a\u101e\u101f])([\u103c\u108a])","\u1082$1$2"), new RabbitRule("\u107e([\u1000\u1003\u1006\u100f\u1010\u1011\u1018\u101a\u101c\u101a\u101e\u101f])([\u1033\u1034]?)([\u1032\u1036\u102d\u102e\u108b\u108c\u108d\u108e])","\u1080$1$2$3"), new RabbitRule("\u103b([\u1000-\u1021])([\u103c\u108a])([\u1032\u1036\u102d\u102e\u108b\u108c\u108d\u108e])","\u1083$1$2$3"), new RabbitRule("\u103b([\u1000-\u1021])([\u103c\u108a])","\u1081$1$2"), new RabbitRule("\u103b([\u1000-\u1021])([\u1033\u1034]?)([\u1032\u1036\u102d\u102e\u108b\u108c\u108d\u108e])","\u107f$1$2$3"), new RabbitRule("\u103a\u103d","\u103d\u103a"), new RabbitRule("\u103a([\u103c\u108a])","$1\u107d"), new RabbitRule("([\u1033\u1034])\u1094","$1\u1095"), new RabbitRule("\u108f\u1071","\u108f\u1072"), new RabbitRule("([\u1000-\u1021])([\u107b\u1066])\u102c","$1\u102c$2"), new RabbitRule("\u102c([\u107b\u1066])\u1037","\u102c$1\u1094") };
        _zg2UniRules = new List<RabbitRule> { new RabbitRule("\u200b",""), new RabbitRule("(\u103d|\u1087)","\u103e"), new RabbitRule("\u103c","\u103d"), new RabbitRule("(\u103b|\u107e|\u107f|\u1080|\u1081|\u1082|\u1083|\u1084)","\u103c"), new RabbitRule("(\u103a|\u107d)","\u103b"), new RabbitRule("\u1039","\u103a"), new RabbitRule("(\u1066|\u1067)","\u1039\u1006"), new RabbitRule("\u106a","\u1009"), new RabbitRule("\u106b","\u100a"), new RabbitRule("\u106c","\u1039\u100b"), new RabbitRule("\u106d","\u1039\u100c"), new RabbitRule("\u106e","\u100d\u1039\u100d"), new RabbitRule("\u106f","\u100d\u1039\u100e"), new RabbitRule("\u1070","\u1039\u100f"), new RabbitRule("(\u1071|\u1072)","\u1039\u1010"), new RabbitRule("\u1060","\u1039\u1000"), new RabbitRule("\u1061","\u1039\u1001"), new RabbitRule("\u1062","\u1039\u1002"), new RabbitRule("\u1063","\u1039\u1003"), new RabbitRule("\u1065","\u1039\u1005"), new RabbitRule("\u1068","\u1039\u1007"), new RabbitRule("\u1069","\u1039\u1008"), new RabbitRule("(\u1073|\u1074)","\u1039\u1011"), new RabbitRule("\u1075","\u1039\u1012"), new RabbitRule("\u1076","\u1039\u1013"), new RabbitRule("\u1077","\u1039\u1014"), new RabbitRule("\u1078","\u1039\u1015"), new RabbitRule("\u1079","\u1039\u1016"), new RabbitRule("\u107a","\u1039\u1017"), new RabbitRule("\u107c","\u1039\u1019"), new RabbitRule("\u1085","\u1039\u101c"), new RabbitRule("\u1033","\u102f"), new RabbitRule("\u1034","\u1030"), new RabbitRule("\u103f","\u1030"), new RabbitRule("\u1086","\u103f"), new RabbitRule("\u1036\u1088","\u1088\u1036"), new RabbitRule("\u1088","\u103e\u102f"), new RabbitRule("\u1089","\u103e\u1030"), new RabbitRule("\u108a","\u103d\u103e"), new RabbitRule("([\u1000-\u1021])\u1064","\u1004\u103a\u1039$1"), new RabbitRule("([\u1000-\u1021])\u108b","\u1004\u103a\u1039$1\u102d"), new RabbitRule("([\u1000-\u1021])\u108c","\u1004\u103a\u1039$1\u102e"), new RabbitRule("([\u1000-\u1021])\u108d","\u1004\u103a\u1039$1\u1036"), new RabbitRule("\u108e","\u102d\u1036"), new RabbitRule("\u108f","\u1014"), new RabbitRule("\u1090","\u101b"), new RabbitRule("\u1091","\u100f\u1039\u100d"), new RabbitRule("\u1019\u102c(\u107b|\u1093)","\u1019\u1039\u1018\u102c"), new RabbitRule("(\u107b|\u1093)","\u1039\u1018"), new RabbitRule("(\u1094|\u1095)","\u1037"), new RabbitRule("\u1096","\u1039\u1010\u103d"), new RabbitRule("\u1097","\u100b\u1039\u100b"), new RabbitRule("\u103c([\u1000-\u1021])([\u1000-\u1021])?","$1\u103c$2"), new RabbitRule("([\u1000-\u1021])\u103c\u103a","\u103c$1\u103a"), new RabbitRule("\u1031([\u1000-\u1021])(\u103e)?(\u103b)?","$1$2$3\u1031"), new RabbitRule("([\u1000-\u1021])\u1031([\u103b\u103c\u103d\u103e]+)","$1$2\u1031"), new RabbitRule("\u1032\u103d","\u103d\u1032"), new RabbitRule("\u103d\u103b","\u103b\u103d"), new RabbitRule("\u103a\u1037","\u1037\u103a"), new RabbitRule("\u102f(\u102d|\u102e|\u1036|\u1037)\u102f","\u102f$1"), new RabbitRule("\u102f\u102f","\u102f"), new RabbitRule("(\u102f|\u1030)(\u102d|\u102e)","$2$1"), new RabbitRule("(\u103e)(\u103b|\u1037)","$2$1"), new RabbitRule("\u1025(\u103a|\u102c)","\u1009$1"), new RabbitRule("\u1025\u102e","\u1026"), new RabbitRule("\u1005\u103b","\u1008"), new RabbitRule("\u1036(\u102f|\u1030)","$1\u1036"), new RabbitRule("\u1031\u1037\u103e","\u103e\u1031\u1037"), new RabbitRule("\u1031\u103e\u102c","\u103e\u1031\u102c"), new RabbitRule("\u105a","\u102b\u103a"), new RabbitRule("\u1031\u103b\u103e","\u103b\u103e\u1031"), new RabbitRule("(\u102d|\u102e)(\u103d|\u103e)","$2$1"), new RabbitRule("\u102c\u1039([\u1000-\u1021])","\u1039$1\u102c"), new RabbitRule("\u103c\u1004\u103a\u1039([\u1000-\u1021])","\u1004\u103a\u1039$1\u103c"), new RabbitRule("\u1039\u103c\u103a\u1039([\u1000-\u1021])","\u103a\u1039$1\u103c"), new RabbitRule("\u103c\u1039([\u1000-\u1021])","\u1039$1\u103c"), new RabbitRule("\u1036\u1039([\u1000-\u1021])","\u1039$1\u1036"), new RabbitRule("\u1092","\u100b\u1039\u100c"), new RabbitRule("\u104e","\u104e\u1004\u103a\u1038"), new RabbitRule("\u1040(\u102b|\u102c|\u1036)","\u101d$1"), new RabbitRule("\u1025\u1039","\u1009\u1039"), new RabbitRule("([\u1000-\u1021])\u103c\u1031\u103d","$1\u103c\u103d\u1031"), new RabbitRule("([\u1000-\u1021])\u103d\u1031\u103b","$1\u103b\u103d\u1031"), new RabbitRule("([\u1000-\u1021])\u1031(\u1039[\u1000-\u1021])","$1$2\u1031"), new RabbitRule(" \u1037","\u1037") };
    }

    public static string Uni2Zg(string input)
    {
        string output = input;
        if (!string.IsNullOrEmpty(input))
        {
            foreach (var rule in _uni2ZgRules)
            {
                output = rule.Apply(output);
            }
        }
        return output;
    }

    public static string Zg2Uni(string input)
    {
        string output = input;
        if (!string.IsNullOrEmpty(input))
        {
            foreach (var rule in _zg2UniRules)
            {
                output = rule.Apply(output);
            }
        }
        return output;
    }

    private class RabbitRule
    {
        private readonly Regex _regex;
        public RabbitRule(string from, string to)
        {
            From = from;
            To = to;

            _regex = new Regex(from, RegexOptions.Compiled);
        }

        public string From { get; private set; }
        public string To { get; private set; }

        public string Apply(string str)
        {
            return _regex.Replace(str, To);
        }
    }
}