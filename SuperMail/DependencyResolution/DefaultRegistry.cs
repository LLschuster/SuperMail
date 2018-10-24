// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SuperMail.DependencyResolution {
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using SuperMail.core.interfaces;
    using SuperMail.core.models;
    using SuperMail.services.concrete;

    public class DefaultRegistry : Registry {
        
        public DefaultRegistry ()
            {
            Scan(scan =>
           {
               scan.TheCallingAssembly();
               scan.WithDefaultConventions();
               scan.With(new ControllerConvention());
           });
            //messageInterface
            For<IMensajes>().Use<Mensajes>();
            //estadosInterface
            For<Iestados>().Use<Estados>();
            //IRepository
            For<Irepository<BaseEntity>>().Use<repository<BaseEntity>>();
            For<Irepository<mensaje>>().Use<repository<mensaje>>();
            For<Irepository<estado>>().Use<repository<estado>>();
            
        }
    }
}