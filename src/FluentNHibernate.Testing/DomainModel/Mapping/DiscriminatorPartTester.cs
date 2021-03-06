using NUnit.Framework;
using FluentNHibernate.Mapping;
using System.Xml;

namespace FluentNHibernate.Testing.DomainModel.Mapping {
	
	[TestFixture]
	public class DiscriminatorPartTester 
	{
        //[Test]
        //public void When_no_discriminator_value_is_explicitly_specified_then_attribute_should_not_be_written() 
        //{
        //    var part = new DiscriminatorPart<int, DiscriminatorTarget>("Discriminator", new ClassMap<DiscriminatorTarget>());

        //    var document = new XmlDocument();
        //    var element = document.CreateElement("class");
        //    part.Write(element, new MappingVisitor());

        //    var discriminatorValue = element.Attributes["discriminator-value"];
        //    Assert.IsNull(discriminatorValue);
        //}

        //[Test]
        //public void When_a_discriminator_value_is_specified_then_an_attribute_should_be_written() 
        //{
        //    var part = new DiscriminatorPart<int, DiscriminatorTarget>("Discriminator", 0, new ClassMap<DiscriminatorTarget>());

        //    var document = new XmlDocument();
        //    var element = document.CreateElement("class");
        //    part.Write(element, new MappingVisitor());

        //    var discriminatorValue = element.Attributes["discriminator-value"];
        //    Assert.That(discriminatorValue.Value, Is.EqualTo("0"));
        //}

        //[Test]
        //public void When_null_is_specified_as_the_discriminator_value_then_attribute_should_not_be_written() 
        //{
        //    var part = new DiscriminatorPart<string, DiscriminatorTarget>("Discriminator", null, null);

        //    var document = new XmlDocument();
        //    var element = document.CreateElement("class");
        //    part.Write(element, new MappingVisitor());

        //    var discriminatorValue = element.Attributes["discriminator-value"];
        //    Assert.IsNull(discriminatorValue);
        //}
	}

	public class DiscriminatorTarget 
	{
	}
}
