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
    /// 框架入口
    /// </summary>
    [DisallowMultipleComponent]
    public abstract class Framework : MonoBehaviour, IBootstrap
    {
        /// <summary>
        /// 调试等级
        /// </summary>
        public DebugLevels DebugLevel = DebugLevels.Production;

        /// <summary>
        /// GameBox Unity Framework
        /// </summary>
        private GBoxUnityFramework application;

        /// <summary>
        /// GameBox Unity Framework
        /// </summary>
        public IGBox Application
        {
            get { return application; }
        }

        /// <summary>
        /// 入口引导
        /// </summary>
        [Priority(0)]
        public virtual void Bootstrap()
        {
            GBox.On<IServiceProvider>(GBoxEvents.OnRegisterProvider, OnRegisterProvider);
            GBox.On(GBoxEvents.OnBootstrap, OnBootstrap);
            GBox.On(GBoxEvents.OnBootstraped, OnBootstraped);
            GBox.On(GBoxEvents.OnInit, OnInit);
            GBox.On<IServiceProvider>(GBoxEvents.OnProviderInit, OnProviderInit);
            GBox.On<IServiceProvider>(GBoxEvents.OnProviderInited, OnProviderInited);
            GBox.On(GBoxEvents.OnInited, OnInited);
            GBox.On(GBoxEvents.OnStartCompleted, OnStartCompleted);
            GBox.On(GBoxEvents.OnTerminate, OnTerminate);
            GBox.On(GBoxEvents.OnTerminated, OnTerminated);
        }

        /// <summary>
        /// 当框架启动完成时
        /// </summary>
        protected abstract void OnStartCompleted();

        /// <summary>
        /// Unity Awake
        /// </summary>
        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
            application = new GBoxUnityFramework(this)
            {
                DebugLevel = DebugLevel
            };
            application.Bootstrap(GetBootstraps());
        }

        /// <summary>
        /// Unity Start
        /// </summary>
        protected virtual void Start()
        {
            application.Init();
        }

        /// <summary>
        /// 注册服务提供者时
        /// </summary>
        /// <param name="provider"></param>
        protected virtual void OnRegisterProvider(IServiceProvider provider)
        {

        }

        /// <summary>
        /// 当所有引导完成时
        /// </summary>
        protected virtual void OnBootstrap()
        {
        }

        /// <summary>
        /// 当所有引导完成时
        /// </summary>
        protected virtual void OnBootstraped()
        {
        }

        /// <summary>
        /// 当终止框架之前
        /// </summary>
        protected virtual void OnTerminate()
        {

        }

        /// <summary>
        /// 当终止框架完成后
        /// </summary>
        protected virtual void OnTerminated()
        {

        }

        /// <summary>
        /// 初始化开始之前
        /// </summary>
        protected virtual void OnInit()
        {

        }

        /// <summary>
        /// 初始化结束之后
        /// </summary>
        protected virtual void OnInited()
        {

        }

        /// <summary>
        /// 当服务提供者初始化之前
        /// </summary>
        /// <param name="provider">准备初始化的服务提供者</param>
        protected virtual void OnProviderInit(IServiceProvider provider)
        {

        }

        /// <summary>
        /// 当服务提供者初始化之后
        /// </summary>
        /// <param name="provider">初始化完成的服务提供者</param>
        protected virtual void OnProviderInited(IServiceProvider provider)
        {

        }

        /// <summary>
        /// 获取引导程序
        /// </summary>
        /// <returns>引导脚本</returns>
        protected virtual IBootstrap[] GetBootstraps()
        {
            return Arr.Merge(GetComponents<IBootstrap>(), Bootstraps.Bootstrap);
        }

        /// <summary>
        /// 当被释放时
        /// </summary>
        protected virtual void OnDestroy()
        {
            if (application != null)
            {
                application.Terminate();
            }
        }
    }
}
