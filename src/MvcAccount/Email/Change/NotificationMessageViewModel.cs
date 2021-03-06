﻿// Copyright 2012 Max Toro Q.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcAccount.Email.Change {
   
   /// <summary>
   /// Holds data for the _NotificationMessage view.
   /// </summary>
   public class NotificationMessageViewModel {

      /// <summary>
      /// The username.
      /// </summary>
      public string Username { get; set; }

      /// <summary>
      /// The name of the website.
      /// </summary>
      /// <seealso cref="AccountConfiguration.SiteName"/>
      public string SiteName { get; set; }

      /// <summary>
      /// The old email.
      /// </summary>
      public string OldEmail { get; set; }

      /// <summary>
      /// The new email.
      /// </summary>
      public string NewEmail { get; set; }

      /// <summary>
      /// A resource where users can ask for help.
      /// </summary>
      /// <seealso cref="AccountConfiguration.HelpResource"/>
      public string HelpResource { get; set; }
   }
}
