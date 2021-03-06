﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using FluentNHibernate.AutoMap.TestFixtures;
using FluentNHibernate.Testing.Fixtures.AutoMappingAlterations.Model;
using NUnit.Framework;

namespace FluentNHibernate.Testing.AutoMap.Apm
{
    [TestFixture]
    public class AutoMappingOverrideAlterationTests
    {
        private AutoMappingOverrideAlteration alteration;

        [SetUp]
        public void CreateOverride()
        {
            alteration = new AutoMappingOverrideAlteration(typeof(ExampleClass).Assembly);
        }

        [Test]
        public void OverridesApplied()
        {
            var model = AutoPersistenceModel.MapEntitiesFromAssemblyOf<Baz>()
                .Where(t => t.Namespace == typeof(Baz).Namespace);

            alteration.Alter(model);
            model.CompileMappings();

            new AutoMappingTester<Baz>(model)
                .Element("class").HasAttribute("was-overridden", "true");
        }

        [Test]
        public void RegularAutoMappingsStillWorkWhenOverridesApplied()
        {
            var model = AutoPersistenceModel.MapEntitiesFromAssemblyOf<Baz>()
                .Where(t => t.Namespace == typeof(Baz).Namespace);

            alteration.Alter(model);
            model.CompileMappings();

            new AutoMappingTester<Baz>(model)
                .Element("class/property[@name='Name']").Exists();
        }
    }
}
