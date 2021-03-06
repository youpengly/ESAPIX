using System;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using ESAPIX.Extensions;
using VMS.TPS.Common.Model.Types;
using XC = ESAPIX.Common.AppComThread;
using V = VMS.TPS.Common.Model.API;
using Types = VMS.TPS.Common.Model.Types;

namespace ESAPIX.Facade.API
{
    public class FieldReferencePoint : ESAPIX.Facade.API.ApiDataObject, System.Xml.Serialization.IXmlSerializable
    {
        public ESAPIX.Facade.API.ReferencePoint ReferencePoint
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("ReferencePoint"))
                    {
                        return _client.ReferencePoint;
                    }
                    else
                    {
                        return default (ESAPIX.Facade.API.ReferencePoint);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        if ((_client.ReferencePoint) != (null))
                        {
                            return new ESAPIX.Facade.API.ReferencePoint(_client.ReferencePoint);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    );
                }
                else
                {
                    return default (ESAPIX.Facade.API.ReferencePoint);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.ReferencePoint = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.VVector RefPointLocation
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("RefPointLocation"))
                    {
                        return _client.RefPointLocation;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.VVector);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.RefPointLocation;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.VVector);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.RefPointLocation = (value);
                }
                else
                {
                }
            }
        }

        public VMS.TPS.Common.Model.Types.DoseValue FieldDose
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("FieldDose"))
                    {
                        return _client.FieldDose;
                    }
                    else
                    {
                        return default (VMS.TPS.Common.Model.Types.DoseValue);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.FieldDose;
                    }

                    );
                }
                else
                {
                    return default (VMS.TPS.Common.Model.Types.DoseValue);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.FieldDose = (value);
                }
                else
                {
                }
            }
        }

        public System.Double EffectiveDepth
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("EffectiveDepth"))
                    {
                        return _client.EffectiveDepth;
                    }
                    else
                    {
                        return default (System.Double);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.EffectiveDepth;
                    }

                    );
                }
                else
                {
                    return default (System.Double);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.EffectiveDepth = (value);
                }
                else
                {
                }
            }
        }

        public System.Double SSD
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("SSD"))
                    {
                        return _client.SSD;
                    }
                    else
                    {
                        return default (System.Double);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.SSD;
                    }

                    );
                }
                else
                {
                    return default (System.Double);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.SSD = (value);
                }
                else
                {
                }
            }
        }

        public System.Boolean IsPrimaryReferencePoint
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("IsPrimaryReferencePoint"))
                    {
                        return _client.IsPrimaryReferencePoint;
                    }
                    else
                    {
                        return default (System.Boolean);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.IsPrimaryReferencePoint;
                    }

                    );
                }
                else
                {
                    return default (System.Boolean);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.IsPrimaryReferencePoint = (value);
                }
                else
                {
                }
            }
        }

        public System.Boolean IsFieldDoseNominal
        {
            get
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    if (((ExpandoObject)(_client)).HasProperty("IsFieldDoseNominal"))
                    {
                        return _client.IsFieldDoseNominal;
                    }
                    else
                    {
                        return default (System.Boolean);
                    }
                }
                else if ((XC.Instance) != (null))
                {
                    return XC.Instance.GetValue(sc =>
                    {
                        return _client.IsFieldDoseNominal;
                    }

                    );
                }
                else
                {
                    return default (System.Boolean);
                }
            }

            set
            {
                if ((_client) is System.Dynamic.ExpandoObject)
                {
                    _client.IsFieldDoseNominal = (value);
                }
                else
                {
                }
            }
        }

        public FieldReferencePoint()
        {
            _client = (new ExpandoObject());
        }

        public FieldReferencePoint(dynamic client)
        {
            _client = (client);
        }
    }
}