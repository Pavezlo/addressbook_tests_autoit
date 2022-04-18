using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            if (!app.Groups.GroupCheck())
            {
                GroupData group = new GroupData()
                {
                    Name = "delite"
                };
                app.Groups.Add(group);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);
            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
