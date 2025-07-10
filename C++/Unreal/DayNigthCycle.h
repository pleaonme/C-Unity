#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "DayNightCycle.generated.h"

UCLASS()
class YOURGAME_API ADayNightCycle : public AActor
{
    GENERATED_BODY()

public:
    ADayNightCycle();

protected:
    virtual void Tick(float DeltaTime) override;

public:
    
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "DayNight")
    float RotationSpeed; // Скорость вращения солнца (градусов в секунду)

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "DayNight")
    class ADirectionalLight* SunLight; // Directional Light для вращения
};
