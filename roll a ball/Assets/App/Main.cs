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
using UnityEngine;

namespace Game
{
    /// <summary>
    /// 项目入口
    /// </summary>
    [DisallowMultipleComponent]
    public class Main : Framework
    {
        /// <summary>
        /// 项目入口
        /// </summary>
        protected override void OnStartCompleted()
        {
            // Game entry, Your code starts writing here
            // called this function after, use GBox.Make function to get service
            // ex: var service = GBox.Make<IYourService>();

            Debug.Log("OnStartCompleted");

            Debug.Log("Hello GameBox, Debug Level: " + GBox.Make<DebugLevels>());
            GBox.Watch<DebugLevels>(newLevel =>
            {
                Debug.Log("Change debug level: " + newLevel);
            });
        }

        /// <summary>
        /// 当引导完成后
        /// </summary>
        protected override void OnBootstraped()
        {
            base.OnBootstraped();
            Debug.Log("OnBootstraped");
        }

        /// <summary>
        /// 当服务提供者初始化之前
        /// </summary>
        /// <param name="provider">准备初始化的服务提供者</param>
        protected override void OnProviderInit(IServiceProvider provider)
        {
            base.OnProviderInit(provider);
            Debug.Log("Initing Provider [<color=#00ff00>" + provider + "</color>]");
        }

        /// <summary>
        /// 当框架终止之前
        /// </summary>
        protected override void OnTerminate()
        {
            base.OnTerminate();
            Debug.Log("OnTerminate");
        }

        /// <summary>
        /// 当框架终止之后
        /// </summary>
        protected override void OnTerminated()
        {
            base.OnTerminated();
            Debug.Log("OnTerminated");
        }

        /// <summary>
        /// 获取引导程序
        /// </summary>
        /// <returns>引导脚本</returns>
        protected override IBootstrap[] GetBootstraps()
        {
            return Arr.Merge(base.GetBootstraps(), Bootstraps.Bootstrap);
        }
    }
}
