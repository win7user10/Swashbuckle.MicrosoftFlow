using System.Collections.Generic;
using Microsoft.OpenApi.Models;

namespace SwashBuckle.MicrosoftExtensions.Helpers
{
    public static class JsonOpenApiResponseFactory
    {
        public static OpenApiResponse Create(string description, OpenApiSchema schema)
        {
            return new()
            {
                Content = new Dictionary<string, OpenApiMediaType>
                {
                    ["application/json"] = new ()
                    {
                        Schema = schema
                    }
                },
                Description = description
            };
        }
    }
}
