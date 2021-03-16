# Copyright 2020 Energinet DataHub A/S
#
# Licensed under the Apache License, Version 2.0 (the "License2");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
data "azurerm_key_vault" "kv_sharedresources" {
  name                = var.sharedresources_keyvault_name
  resource_group_name = var.sharedresources_resource_group_name
}

data "azurerm_key_vault_secret" "VALIDATION_REPORTS_CONNECTION_STRING" {
  name         = "VALIDATION-REPORTS-QUEUE-CONNECTION-STRING"
  key_vault_id = data.azurerm_key_vault.kv_sharedresources.id
}

data "azurerm_key_vault_secret" "VALIDATION_REPORTS_QUEUE_URL" {
  name         = "VALIDATION-REPORTS-QUEUE-URL"
  key_vault_id = data.azurerm_key_vault.kv_sharedresources.id
}

data "azurerm_key_vault_secret" "VALIDATION_REPORTS_QUEUE_TOPIC" {
  name         = "VALIDATION-REPORTS-QUEUE-TOPIC-NAME"
  key_vault_id = data.azurerm_key_vault.kv_sharedresources.id
}

data "azurerm_key_vault_secret" "POST_OFFICE_QUEUE_CONNECTION_STRING" {
  name         = "POST-OFFICE-QUEUE-CONNECTION-STRING"
  key_vault_id = data.azurerm_key_vault.kv_sharedresources.id
}

data "azurerm_key_vault_secret" "POST_OFFICE_QUEUE_MARKETDATA_TOPIC_NAME" {
  name         = "POST-OFFICE-QUEUE-MARKETDATA-TOPIC-NAME"
  key_vault_id = data.azurerm_key_vault.kv_sharedresources.id
}