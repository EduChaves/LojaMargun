import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateProductComponent } from './Components/Product/create-product/create-product.component';
import { DetailProductComponent } from './Components/Product/detailproduct/detailproduct.component';
import { ListProductComponent } from './Components/Product/list-product/list-product.component';

const routes: Routes = [
  { path: 'product/createproduct', component: CreateProductComponent },
  { path: 'product/listproduct', component: ListProductComponent },
  { path: 'product/detailproduct/:id', component: DetailProductComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: []
})

export class AppRoutingModule { }