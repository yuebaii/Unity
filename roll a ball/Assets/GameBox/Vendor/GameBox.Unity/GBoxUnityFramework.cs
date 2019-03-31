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

using UnityEngine;

namespace GameBox
{
    /// <summary>
    /// GameBox Framewor for Unity
    /// </summary>
    public class GBoxUnityFramework : GBoxFramework
    {
        /// <summary>
        /// behaviour
        /// </summary>
        private readonly MonoBehaviour behaviour;

        /// <summary>
        /// 构造一个 GameBox Framewor for Unity
        /// </summary>
        /// <param name="behaviour">驱动器</param>
        public GBoxUnityFramework(MonoBehaviour behaviour)
        {
            if (behaviour == null)
            {
                return;
            }

            this.Singleton<MonoBehaviour>(() => behaviour)
                .Alias<Component>();
            this.behaviour = behaviour;
        }

        /// <summary>
        /// 初始化服务提供者
        /// </summary>
        public override void Init()
        {
            if (behaviour != null)
            {
                behaviour.StartCoroutine(CoroutineInit());
                return;
            }
            base.Init();
        }

        /// <summary>
        /// 注册服务提供者
        /// </summary>
        /// <param name="provider">服务提供者</param>
        public override void Register(IServiceProvider provider)
        {
            if (behaviour != null)
            {
                behaviour.StartCoroutine(CoroutineRegister(provider));
                return;
            }
            base.Init();
        }
    }
}