using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Jdp.Jdf.LinqToJdf;
using Machine.Specifications;

namespace Jdp.Jdf.Tests.Unit.LinqToJdf.ResourceExtensions {
    [Subject(typeof(Jdf.LinqToJdf.ResourceExtensions))]
    public class when_using_set_id_on_stand_alone_resource_element {
        static XElement bindingIntent;

        Establish content = () => bindingIntent = new XElement(Resource.BindingIntent);

        Because of = () => bindingIntent.SetId("zz1");

        It should_return_a_list_of_references = () => bindingIntent.ReferencingElements().ShouldNotBeNull();

        It should_have_no_referencing_elements = () => bindingIntent.ReferencingElements().Count().ShouldEqual(0);
    }
}