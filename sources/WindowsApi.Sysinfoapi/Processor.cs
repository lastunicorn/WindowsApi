// WindowsApi
// Copyright (C) 2020-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace DustInTheWind.WindowsApi.Sysinfoapi
{
    public enum Processor : uint
    {
        INTEL_386 = 386,

        INTEL_486 = 486,

        INTEL_PENTIUM = 586,

        INTEL_IA64 = 2200,

        MIPS_R4000 = 4000,

        AMD_X8664 = 8664,

        ALPHA_21064 = 21064
    }
}