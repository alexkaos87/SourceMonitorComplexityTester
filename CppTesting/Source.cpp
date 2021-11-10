#include "pch.h"

namespace alexkaos
{
    // complexity = 4, Statements = 4, Max Depth = 3, Calls = 1
    // modified complexity = 4*, Statements = 4, Max Depth = 3, Calls = 1
    void FunctionWith3If()
    {
        auto variable1 = std::rand();
        if (variable1 > 0)
        {
            if (variable1 < 1000)
            {
                if (variable1 > 100)
                {
                    // TODO
                }
            }
        }
    }

    // complexity = 13, Statements = 26, Max Depth = 2, Calls = 1
    // modified complexity = 2*, Statements = 26, Max Depth = 2, Calls = 1
    void FunctionWith1SwitchAnd10Cases()
    {
        auto variable1 = std::rand();

        switch (variable1)
        {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            break;
        default:
            break;
        }
    }

    // complexity = 16, Statements = 29, Max Depth = 3, Calls = 1
    // modified complexity = 5*, Statements = 29, Max Depth = 3, Calls = 1
    void FunctionWith3IfAnd1SwitchAnd10Cases()
    {
        auto variable1 = std::rand();
        if (variable1 > 0)
        {
            if (variable1 < 1000)
            {
                if (variable1 > 100)
                {
                    // TODO
                }
            }
        }

        switch (variable1)
        {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            break;
        default:
            break;
        }
    }
}