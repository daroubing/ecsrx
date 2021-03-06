﻿using Assets.EcsRx.Unity.Extensions;
using EcsRx.Unity;
using UnityEngine;

namespace Assets.EcsRx.Examples.GameObjectLinking
{
    public class Application : EcsRxApplication
    {
        protected override void GameStarting()
        {
            RegisterAllBoundSystems();
        }

        protected override void GameStarted()
        {
            var defaultPool = PoolManager.GetPool();
            var entity = defaultPool.CreateEntity();

            var existingGameObject = GameObject.Find("ExistingGameObject");
            existingGameObject.LinkEntity(entity, defaultPool);
        }
    }
}