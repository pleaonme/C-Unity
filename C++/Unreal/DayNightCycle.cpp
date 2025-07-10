#include "DayNightCycle.h"
#include "Engine/DirectionalLight.h"

ADayNightCycle::ADayNightCycle()
{
    PrimaryActorTick.bCanEverTick = true;
    RotationSpeed = 5.0f; // по умолчанию 5 градусов в секунду
}

void ADayNightCycle::Tick(float DeltaTime)
{
    Super::Tick(DeltaTime);

    if (!SunLight) return;

    FRotator CurrentRotation = SunLight->GetActorRotation(); // Получаем вращение Directional Light
    CurrentRotation.Pitch += RotationSpeed * DeltaTime; 
    SunLight->SetActorRotation(CurrentRotation); // Устанавливаем новую позицию вращения
}
