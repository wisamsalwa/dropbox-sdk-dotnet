// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Shared folder user and group membership.</para>
    /// </summary>
    public class SharedFolderMembers
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMembers> Encoder = new SharedFolderMembersEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMembers> Decoder = new SharedFolderMembersDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMembers" />
        /// class.</para>
        /// </summary>
        /// <param name="users">The list of user members of the shared folder.</param>
        /// <param name="groups">The list of group members of the shared folder.</param>
        /// <param name="invitees">The list of invitees to the shared folder.</param>
        /// <param name="cursor">Present if there are additional shared folder members that
        /// have not been returned yet. Pass the cursor into <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListFolderMembersContinueAsync" />
        /// to list additional members.</param>
        public SharedFolderMembers(col.IEnumerable<UserMembershipInfo> users,
                                   col.IEnumerable<GroupMembershipInfo> groups,
                                   col.IEnumerable<InviteeMembershipInfo> invitees,
                                   string cursor = null)
        {
            var usersList = enc.Util.ToList(users);

            if (users == null)
            {
                throw new sys.ArgumentNullException("users");
            }

            var groupsList = enc.Util.ToList(groups);

            if (groups == null)
            {
                throw new sys.ArgumentNullException("groups");
            }

            var inviteesList = enc.Util.ToList(invitees);

            if (invitees == null)
            {
                throw new sys.ArgumentNullException("invitees");
            }

            this.Users = usersList;
            this.Groups = groupsList;
            this.Invitees = inviteesList;
            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMembers" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public SharedFolderMembers()
        {
        }

        /// <summary>
        /// <para>The list of user members of the shared folder.</para>
        /// </summary>
        public col.IList<UserMembershipInfo> Users { get; protected set; }

        /// <summary>
        /// <para>The list of group members of the shared folder.</para>
        /// </summary>
        public col.IList<GroupMembershipInfo> Groups { get; protected set; }

        /// <summary>
        /// <para>The list of invitees to the shared folder.</para>
        /// </summary>
        public col.IList<InviteeMembershipInfo> Invitees { get; protected set; }

        /// <summary>
        /// <para>Present if there are additional shared folder members that have not been
        /// returned yet. Pass the cursor into <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListFolderMembersContinueAsync" />
        /// to list additional members.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMembers" />.</para>
        /// </summary>
        private class SharedFolderMembersEncoder : enc.StructEncoder<SharedFolderMembers>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMembers value, enc.IJsonWriter writer)
            {
                WriteListProperty("users", value.Users, writer, Dropbox.Api.Sharing.UserMembershipInfo.Encoder);
                WriteListProperty("groups", value.Groups, writer, Dropbox.Api.Sharing.GroupMembershipInfo.Encoder);
                WriteListProperty("invitees", value.Invitees, writer, Dropbox.Api.Sharing.InviteeMembershipInfo.Encoder);
                if (value.Cursor != null)
                {
                    WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMembers" />.</para>
        /// </summary>
        private class SharedFolderMembersDecoder : enc.StructDecoder<SharedFolderMembers>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMembers" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMembers Create()
            {
                return new SharedFolderMembers();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderMembers value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "users":
                        value.Users = ReadList<UserMembershipInfo>(reader, Dropbox.Api.Sharing.UserMembershipInfo.Decoder);
                        break;
                    case "groups":
                        value.Groups = ReadList<GroupMembershipInfo>(reader, Dropbox.Api.Sharing.GroupMembershipInfo.Decoder);
                        break;
                    case "invitees":
                        value.Invitees = ReadList<InviteeMembershipInfo>(reader, Dropbox.Api.Sharing.InviteeMembershipInfo.Decoder);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
