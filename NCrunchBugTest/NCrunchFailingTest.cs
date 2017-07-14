using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Ploeh.AutoFixture;
using Xunit;

namespace NCrunchBugTest
{
    public class ArticleContents
    {
        public string Author { get; set; }
    }

    public class NCrunchFailingTest
    {
        public static IEnumerable<object[]> ArticleContentsEqualityExamples()
        {
            var fixture = new Fixture();
            var original = fixture.Create<ArticleContents>();
            var clone = Clone(original);
            // returning json contents so that xunit properly handle multi values (needs deserialization etc)
            yield return new object[] { JsonConvert.SerializeObject(original), JsonConvert.SerializeObject(clone), "Identical clone" };
        }

        [Theory]
        [MemberData(nameof(ArticleContentsEqualityExamples))]
        public void ArticleContents_must_remain_equal_when_changing_unimportant_parts(string originalJson, string modifiedCloneJson, string reason)

        {
            // what is here does not matter
        }

        private static T Clone<T>(T original)
        {
            // hacky way of cloning serialize/deserialize :p
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(original));
        }
    }
}
