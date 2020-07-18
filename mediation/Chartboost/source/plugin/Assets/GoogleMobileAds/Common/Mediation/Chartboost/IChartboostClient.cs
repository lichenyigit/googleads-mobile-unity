﻿// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

using GoogleMobileAds.Api.Mediation.Chartboost;

namespace GoogleMobileAds.Common.Mediation.Chartboost
{
    public interface IChartboostClient
    {
        // Sets GDPR consent for the Chartboost SDK.
        void AddDataUseConsent(ChartboostGDPRConsent gdprConsent);

        // Sets CCPA consent for the Chartboost SDK.
        void AddDataUseConsent(ChartboostCCPAConsent ccpaConsent);

        // Sets a custom data use consent for the Chartboost SDK.
        // This API should only be used for iOS.
        void AddDataUseConsent(ChartboostConsentType consentType, string customConsent);

        // Sets a custom data use consent for the Chartboost SDK.
        // This API should only be used for Android.
        void AddDataUseConsent(string customConsentName, string customConsentValue);

        // Clears any consent data for the Chartboost SDK.
        // This API should only be used for iOS.
        void ClearDataUseConsent(ChartboostConsentType consentType);

        // Clears any consent data for the Chartboost SDK.
        // This API should only be used for Android.
        void ClearDataUseConsent(string privacyStandard);
    }
}
