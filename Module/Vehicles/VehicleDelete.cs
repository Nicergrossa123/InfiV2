﻿using GTANetworkAPI;

namespace GVRP.Module.Vehicles
{
    public static class VehicleDelete
    {
        public static void DeleteVehicle(this Vehicle vehicle)
        {
            if (vehicle.HasData("loadedVehicle"))
            {
                Vehicle loadedVehicle = vehicle.GetData<Vehicle>("loadedVehicle");
                loadedVehicle.Delete();
                vehicle.ResetData("loadedVehicle");
            }

            NAPI.Task.Run(vehicle.Delete); //DeleteEntity
        }
    }
}