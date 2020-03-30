// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace webfrontend.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}