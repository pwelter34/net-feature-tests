﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FeatureTests.Shared {
    public abstract class LibraryAdapterBase : ILibrary {
        public virtual string Name {
            get { return Regex.Match(this.GetType().Name, "^(.+?)(?:Adapter)?$").Groups[1].Value; }
        }

        public abstract Assembly Assembly { get; }

        public virtual string PackageId {
            get { return Assembly.GetName().Name; }
        }
    }
}
