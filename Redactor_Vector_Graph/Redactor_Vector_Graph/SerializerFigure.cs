using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;

namespace Redactor_Vector_Graph {
    class SerializerFigure {
        static string strReturn = "";
        public static string SerializeAllFigures(ref List<Figure> figureArray) {
            strReturn = "";
            strReturn += "[";
            foreach (var figure in figureArray) {
                Type typeFigure = figure.GetType();
                strReturn += "{" + "\"__type\":" + "\"" + typeFigure.Name + ":#" + typeFigure.Namespace + "\",";
                var fields = typeFigure.GetFields();
                foreach (var field in fields) {
                    if (field.GetCustomAttribute(typeof(DataMemberAttribute)) != null) {
                        SerializeMember(field.Name, field.GetValue(figure));

                    }
                }
                strReturn = strReturn.Remove(strReturn.Length - 1);
                strReturn += "},";
            }
            strReturn = strReturn.Remove(strReturn.Length - 1);
            strReturn += "]";
            return strReturn;
        }
        public static string SerializeFigure(ref Figure figure) {
            strReturn = "";
            Type typeFigure = figure.GetType();
                strReturn += "{" + "\"__type\":" + "\"" + typeFigure.Name + ":#" + typeFigure.Namespace + "\",";
                var fields = typeFigure.GetFields();
                foreach (var field in fields) {
                    if (field.GetCustomAttribute(typeof(DataMemberAttribute)) != null) {
                        SerializeMember(field.Name, field.GetValue(figure));
                    }
                }
                strReturn = strReturn.Remove(strReturn.Length - 1);
                strReturn += "},";
            return strReturn;
        }
        static private void SerializeMember(string name, object obj) {
            if (name != "")
                strReturn += "\"" + name + "\":";
           
            if (obj == null) {
                strReturn += "null,";
                return;
            }

            Type typeField = obj.GetType();
            if (obj is IEnumerable) {
                strReturn += "[";
                foreach (var member in (IEnumerable)obj) {
                        SerializeMember("", member);
                }
                strReturn = strReturn.Remove(strReturn.Length - 1);
                strReturn += "],";
                return;
            }
            if (typeField.IsClass) {
                strReturn += "{";
                var fields = typeField.GetFields();
                foreach (var field in fields) {
                    if (field.FieldType.IsSerializable && !field.IsStatic) {
                        SerializeMember(field.Name, field.GetValue(obj));
                    }
                }
                strReturn = strReturn.Remove(strReturn.Length - 1);
                strReturn += "},";
                return;
            }
            if (typeField.IsValueType) {
                if (typeField.IsPrimitive) {
                    if (obj is int || obj is Int64 || obj is Int16) {
                        strReturn += Convert.ChangeType(obj, typeField);
                    }
                    if ( obj is double) {
                        strReturn += ((double)obj).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (obj is float) {
                        strReturn += ((float)obj).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (obj is string) {
                        strReturn += "\"" + (string)obj + "\"";
                    }
                    if (obj is bool) {
                        strReturn += (bool)obj ? "true" : "false";
                    }
                }
                else {
                    strReturn += "{";
                    var fields = typeField.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                    foreach (var field in fields) {
                        if (field.FieldType.IsSerializable) {
                            SerializeMember(field.Name, field.GetValue(obj));
                        }
                    }
                    strReturn = strReturn.Remove(strReturn.Length - 1);
                    strReturn += "}";
                }
                strReturn += ",";
            }

            }
        }
    }
