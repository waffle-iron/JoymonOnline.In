﻿<%@ Page Language="C#" MasterPageFile="~/site.master" Title="Joymon Online | Links"
    CodeBehind="Links.aspx.cs" Inherits="JoymonOnline.Links" %>
<%@ OutputCache CacheProfile="Cache1Week" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

    <div class="shim column"></div>

    <div class="page" id="links">
        <div id="content">
            <h3>About the Links</h3>
            <p>The links below contains my presence in the web other than this site.Those links include my blogs,photo galleries and profiles in various social sites.</p>

            <h4>My Blogs</h4>
            <dl>
                <dt><a href="http://www.joyfulwpf.blogspot.com" target="_blank">Joymon's World of WPF</a></dt>
                <dd>A blog about the new Microsoft technology WPF.</dd>
                <dt><a href="http://www.silverlightedweb.blogspot.com" target="_blank">SilverlightedWeb</a></dt>
                <dd>Blogs about Microsoft RIA platform Silverlight.</dd>
                <dt><a href="http://www.joymonscode.blogspot.com" target="_blank">Joymon v/s Code</a></dt>
                <dd>General progamming blog with code snippets.</dd>
            </dl>
            <h4>My Profile in Social sites</h4>
            <dl>
                <dt><a href="http://www.new.facebook.com/profile.php?id=832130326" target="_blank">Facebook</a></dt>
                <dd>Facebook.</dd>
                <dt><a href="https://www.linkedin.com/in/joymon" target="_blank">LinkedIn</a></dt>
                <dd>LinkedIn.</dd>
            </dl>
            <h4>Technology profiles</h4>
            <dl>
                <dt><a href="http://stackoverflow.com/users/181832/joymon">Stackoverflow</a></dt>
                <dd>Question answer site for developers</dd>
                <dt><a href="https://github.com/joymon/">Github</a></dt>
                <dd>Source code repository for my open source projects.</dd>
            </dl>
            <h4>Media Sites</h4>
            <dl>
                <dt><a href="http://picasaweb.google.com/joymon" target="_blank">Picasa photo album</a></dt>
                <dd>My photos in Google picasa.</dd>
                <dt><a href="http://www.youtube.com/user/joygeorgek" target="_blank">Youtube</a></dt>
                <dd>A place where I have uploaded videos.</dd>
            </dl>
        </div>
    </div>

</asp:Content>
