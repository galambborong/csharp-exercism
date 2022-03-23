using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>
        (knightIsAwake, archerIsAwake, prisonerIsAwake) switch
        {
            (true, _, _) => true,
            (_, true, _) => true,
            (_, _, true) => true,
            _ => false
        };

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) =>
        (archerIsAwake, prisonerIsAwake) switch
        {
            (false, true) => true,
            _ => false
        };

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake,
        bool petDogIsPresent) => (knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent) switch
    {
        (true, true, true, true) => false,
        (true, false, true, false) => false,
        (_, true, true, false) => false,
        (_, true, _, true) => false,
        (_, _, true, false) => true,
        (_, _, _, false) => false,
        (_, _, _, true) => true,
    };
}
