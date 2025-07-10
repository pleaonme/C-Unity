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
    virtual void BeginPlay() override;

public:    
    virtual void Tick(float DeltaTime) override;

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "DayNight")
    float DayDuration; // Длительность суток в секундах

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "DayNight")
    class ADirectionalLight* SunLight; // Directional Light который нужно вращать

private:
    float TimeAccumulator;
};
