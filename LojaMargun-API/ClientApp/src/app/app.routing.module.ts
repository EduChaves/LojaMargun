import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateProductComponent } from './Components/Product/create-product/create-product.component';
import { ListProductComponent } from './Components/Product/list-product/list-product.component';

const routes: Routes = [
  {path: 'product/createproduct', component: CreateProductComponent},
  {path: 'product/listproduct', component: ListProductComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: []
})

export class AppRoutingModule { }