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

using GameBox;

namespace Game
{
    /// <summary>
    /// 项目注册的引导程序
    /// </summary>
    public class Bootstraps
    {
        /// <summary>
        /// 项目注册的引导程序
        /// </summary>
        public static IBootstrap[] Bootstrap
        {
            get
            {
                return new IBootstrap[]
                {
                    new BootstrapTypeFinder(Assemblys.Assembly),
                    new BootstrapProviderRegister(Providers.ServiceProviders),
                };
            }
        }
    }
}
