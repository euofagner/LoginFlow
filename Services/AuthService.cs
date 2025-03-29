using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace LoginFlow.Services;

public class AuthService
{
    public async Task<bool> IsAuthenticadeAsync()
    {
        await Task.Delay(2000);
        return true;
    }
}
