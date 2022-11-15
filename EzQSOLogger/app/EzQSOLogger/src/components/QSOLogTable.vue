<script setup lang="ts">
import type { ColDef } from "ag-grid-community";
import "ag-grid-community/styles/ag-grid.css";
import "ag-grid-community/styles/ag-theme-alpine.css";
import { AgGridVue } from "ag-grid-vue3";
import { onMounted, reactive } from "vue";

const props = withDefaults(
  defineProps<{
    initialData: any[]
  }>(),
  {
    initialData: () => []
  }
)

var columnDefs: ColDef[] = [
  { field: "callsign" },
  { field: "frequency" },
  { field: "mode" },
  { field: "time" },
  { field: "signal" },
]
var rowData = reactive(props.initialData || [])



</script>

<template>
  <w-flex rows="1" columns="1">
    <ag-grid-vue style="width: 100%; height: 400px" class="ag-theme-alpine" :columnDefs="columnDefs" :rowData="rowData">
    </ag-grid-vue>
  </w-flex>
</template>