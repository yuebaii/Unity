/*
 * This file is part of the GameBox package.
 *
 * (c) Giant - MouGuangYi <mouguangyi@ztgame.com> , Yu Bin <yubin@ztgame.com>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://docs.ztgame.com/gamebox-core
 */

using System.Collections.Generic;

namespace Game
{
    /// <summary>
    /// 项目自动添加的程序集自动加载方案
    /// </summary>
    public class Assemblys
    {
        /// <summary>
        /// 项目自动添加的程序集自动加载方案
        /// </summary>
        public static IDictionary<string, int> Assembly
        {
            get
            {
                return new Dictionary<string, int>
                {
                    //{ "Assembly-CSharp" , 0 },
                };
            }
        }
    }
}
