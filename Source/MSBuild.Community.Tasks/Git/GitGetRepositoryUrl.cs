//
//  GitGetRepositoryUrl.cs
//
//  Authors:
//       David G. Moore, Jr. <david@dgmjr.io>
//
//  Copyright ©️ 2022 David G. Moore, Jr.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.


namespace MSBuild.Community.Tasks.Git;

using static GitConstants;

public class GitGetRepositoryUrl : GitClient
{
    public GitGetRepositoryUrl()
    {
        Command = GetUrl;
        Arguments = Origin;
    }
}
