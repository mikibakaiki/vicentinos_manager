import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FamilyDetailComponent } from './families/family-detail/family-detail.component';
import { FamilyListComponent } from './families/family-list/family-list.component';
import { AuthGuard } from './guards/auth.guard';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';

const routes: Routes = [
    { path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'families', component: FamilyListComponent },
            { path: 'families/:id', component: FamilyDetailComponent },
            { path: 'lists', component: ListsComponent },
        ]
    },
    { path: '**', component: HomeComponent, pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
